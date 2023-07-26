using UnityEngine;

public class EnemyScript: AutoMovable {

	void Start() {
		Init(-15f, false, RigidbodyConstraints.FreezeRotation);
		gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
		gameObject.tag = "Enemy";
	}

	void FixedUpdate() {
		Move();
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(gameObject);
	}
}
