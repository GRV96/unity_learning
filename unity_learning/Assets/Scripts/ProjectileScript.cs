using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		// Rien
	}

	// Update is called once per frame
	void Update()
	{
		float deltaZ = 0.3f;
		transform.Translate(Vector3.forward * deltaZ);
	}
}
