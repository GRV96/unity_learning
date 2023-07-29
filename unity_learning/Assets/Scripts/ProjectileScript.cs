using UnityEngine;

public class ProjectileScript: AutoMovable {

	void Start() {
		Init(25f, false);
		gameObject.tag = "Projectile";
	}

	void FixedUpdate() {
		Move();
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(gameObject);
	}
}
