using UnityEngine;

public class EnemyScript: AutoMovable {
	private GameStatus _gameStatus = GameStatus.Instance;

	void Start() {
		Init(-15f, false, RigidbodyConstraints.FreezeRotation);
		gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
		gameObject.tag = "Enemy";
	}

	void FixedUpdate() {
		Move();
	}

	void OnCollisionEnter(Collision collision) {
		string tag = collision.gameObject.tag;

		switch(tag) {
			case "Projectile":
				_gameStatus.EnemiesKilled++;
				break;
			case "Wall":
				_gameStatus.EnemiesEscaped++;
				break;
		}

		Destroy(gameObject);
	}
}
