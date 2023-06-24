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
		transform.Translate(
			Vector3.forward * 0.3f * Input.GetAxis("Vertical"));
		transform.Translate(
			Vector3.right * 0.2f * Input.GetAxis("Horizontal"));
	}
}
