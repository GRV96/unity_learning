using UnityEngine;

public class ProjectileScript: AutoMovable {

	void Start() {
		Init(25f, false);
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(gameObject);
	}

	void FixedUpdate() {
		Move();
	}
}
