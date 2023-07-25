using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript: MonoBehaviour {
	private Rigidbody _rigidbody = null;
	private Vector3 _positionDelta = Vector3.forward * 25f;

	void Start() {
		_rigidbody = gameObject.AddComponent<Rigidbody>();
		_rigidbody.useGravity = false;
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(gameObject);
	}

	void FixedUpdate() {
		_rigidbody.MovePosition(
			_rigidbody.position + _positionDelta * Time.deltaTime);
	}
}
