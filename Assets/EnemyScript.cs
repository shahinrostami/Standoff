using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public PlayerScript Player;
	float movementSpeed = 0.25f;
	int step = 1;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (!LeanTween.isTweening (Player.gameObject)) {
			if (Input.GetKeyDown (KeyCode.W) ||
			   Input.GetKeyDown (KeyCode.A) ||
			   Input.GetKeyDown (KeyCode.S) ||
			   Input.GetKeyDown (KeyCode.D)) {
				Vector3 diff = (transform.position - Player.transform.position);

				if (Mathf.Abs (diff.x) + Mathf.Abs (diff.z) <= 1) {
					step = 2;
				} else {
					step = 1;
				}


					LeanTween.moveX (gameObject, transform.position.x - (step * (diff.x / Mathf.Abs(diff.x))), movementSpeed);	
				
					LeanTween.moveZ (gameObject, transform.position.z - (step * (diff.z / Mathf.Abs(diff.z))), movementSpeed);	


			}
		}
	}

	void OnTriggerEnter(Collider col){
		// do something when caught
		Destroy(col.gameObject);
	}


}
