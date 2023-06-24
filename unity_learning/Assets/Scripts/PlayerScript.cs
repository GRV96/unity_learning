using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	// Start is called before the first frame update.
	void Start() {
		transform.SetPositionAndRotation(
			new Vector3(0.0f, 1.4f, -14.0f),
			new Quaternion(0.0f, 0.0f, 0.0f, 1));
	}

	// FixedUpdate is called once per frame.
	void FixedUpdate() {
		float zSpeed = 0.3f * Input.GetAxis("Vertical");
		float xSpeed = 0.2f * Input.GetAxis("Horizontal");
		//*
		transform.Translate(Vector3.forward * zSpeed);
		transform.Translate(Vector3.right * xSpeed);
		//*/
		/*
		rigidbody.velocity.z = zSpeed;
		rigidbody.velocity.x = xSpeed;
		//*/
	}
}
