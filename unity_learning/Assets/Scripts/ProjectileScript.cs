using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript: MonoBehaviour {
	private Rigidbody _rigidbody = null;
	private Vector3 _positionDelta = Vector3.forward * 25f;

	void Start() {
		//_rigidbody = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision collision) {
		print("Collision!");
		Destroy(gameObject);
	}

	void FixedUpdate() {
		/*
		_rigidbody.MovePosition(
			_rigidbody.position + _positionDelta * Time.deltaTime);
		//*/
		transform.Translate(_positionDelta * Time.deltaTime);
	}
}
