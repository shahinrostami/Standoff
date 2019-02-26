using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	float movementSpeed = 0.25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!LeanTween.isTweening(gameObject)) {
			if (Input.GetKeyDown (KeyCode.W)) {
				LeanTween.moveZ (gameObject, transform.position.z + 1f, movementSpeed);	
			}
			else if (Input.GetKeyDown (KeyCode.S)) {
				LeanTween.moveZ (gameObject, transform.position.z - 1f, movementSpeed);	
			}
			else if (Input.GetKeyDown (KeyCode.A)) {
				LeanTween.moveX (gameObject, transform.position.x - 1f, movementSpeed);	
			}
			else 	if (Input.GetKeyDown (KeyCode.D)) {
				LeanTween.moveX (gameObject, transform.position.x + 1f, movementSpeed);	
			}
		}
	}
}
