using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
	// Start is called before the first frame update.
	void Start() {
		// Rien
	}

	void OnCollisionEnter(Collision collision) {
		print("Collision!");
		Destroy(gameObject);
	}

	// FixedUpdate is called once per frame.
	void FixedUpdate() {
		float deltaZ = 0.5f;
		transform.Translate(Vector3.forward * deltaZ);
	}
}
