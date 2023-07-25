using UnityEngine;

public class EnemyScript: AutoMovable {

	void Start() {
		Init(-10f, false, RigidbodyConstraints.FreezeRotation);
		gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
	}

	void FixedUpdate() {
		Move();
	}

	void OnCollisionEnter(Collision collision) {
		Destroy(gameObject);
	}
}
