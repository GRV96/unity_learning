using UnityEngine;

public class EnemyScript: AutoMovable {

	void Start() {
		Init(-10f, true, RigidbodyConstraints.FreezeRotation);
		gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
	}

	void FixedUpdate() {
		Move();
	}
}
