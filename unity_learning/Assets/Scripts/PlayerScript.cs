using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript: MonoBehaviour {
	private Rigidbody _rigidbody = null;

	// The initial distance between the player and the projectile
	private Vector3 _projectileGap = new Vector3(0f, 0f, 1.5f);

	void Start() {
		_rigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		float deltaX = Time.deltaTime * 10f * Input.GetAxis("Horizontal");
		float deltaZ = Time.deltaTime * 15f * Input.GetAxis("Vertical");
		_rigidbody.MovePosition(
			_rigidbody.position + new Vector3(deltaX, 0f, deltaZ));

		if(Input.GetKeyDown("space")) {
			GameObject projectile =
				GameObject.CreatePrimitive(PrimitiveType.Sphere);
			projectile.transform.position =
				transform.position + _projectileGap;
			System.Type ProjectileScript =
				System.Type.GetType ("ProjectileScript,Assembly-CSharp");
			projectile.AddComponent(ProjectileScript);
		}
	}
}
