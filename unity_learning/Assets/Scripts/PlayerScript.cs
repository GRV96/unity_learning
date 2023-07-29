using UnityEngine;

public class PlayerScript: MonoBehaviour {
	private GameStatus _gameStatus = GameStatus.Instance;

	private Rigidbody _rigidbody = null;

	// The initial distance between the player and the projectile
	private Vector3 _projectileGap = new Vector3(0f, 0f, 1.5f);

	private System.Type ProjectileScript =
		System.Type.GetType("ProjectileScript,Assembly-CSharp");

	private int _lives;

	void Start() {
		_rigidbody = GetComponent<Rigidbody>();
		Reset();
	}

	void FixedUpdate() {
		float deltaX = Time.deltaTime * 10f * Input.GetAxis("Horizontal");
		float deltaZ = Time.deltaTime * 15f * Input.GetAxis("Vertical");
		_rigidbody.MovePosition(
			_rigidbody.position + new Vector3(deltaX, 0f, deltaZ));

		if(Input.GetKeyDown("s")) {
			ShootProjectile();
		}
	}

	private void MakePlayerAlive(bool pIsAlive) {
		gameObject.SetActive(pIsAlive);
		_gameStatus.PlayerIsAlive = pIsAlive;
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag.Equals("Enemy")) {
			if(--_lives == 0) {
				MakePlayerAlive(false);
			}
		}
	}

	private void Reset() {
		_lives = 1;
		MakePlayerAlive(true);
	}

	private void ShootProjectile() {
		GameObject projectile =
			GameObject.CreatePrimitive(PrimitiveType.Sphere);
		projectile.transform.position =
			transform.position + _projectileGap;
		projectile.AddComponent(ProjectileScript);
	}
}
