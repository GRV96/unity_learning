using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
	private Rigidbody rigidbody = null;

	// Start is called before the first frame update.
	void Start() {
		rigidbody = GetComponent<Rigidbody>();
		transform.SetPositionAndRotation(
			new Vector3(0.0f, 1.4f, -14.0f),
			new Quaternion(0.0f, 0.0f, 0.0f, 1));
	}

	// FixedUpdate is called once per frame.
	void FixedUpdate() {
		float deltaX = 0.2f * Input.GetAxis("Horizontal");
		float deltaZ = 0.3f * Input.GetAxis("Vertical");
		/*
		transform.Translate(Vector3.right * deltaX);
		transform.Translate(Vector3.forward * deltaZ);
		//*/
		//*
		rigidbody.MovePosition(
			rigidbody.position + new Vector3(deltaX, 0f, deltaZ));
		//*/
	}

	//*
	void OnKeyDown(KeyDownEvent kde) {
		if(kde.character == ' ') {
			Debug.Log("Espace");
			GameObject projectile =
				GameObject.CreatePrimitive(PrimitiveType.Sphere);
			// Copies the positon.
			projectile.transform.position = transform.position * 1;
			System.Type ProjectileScript =
				System.Type.GetType ("ProjectileScript,Assembly-CSharp");
			projectile.AddComponent(ProjectileScript);
		}
	}//*/
}