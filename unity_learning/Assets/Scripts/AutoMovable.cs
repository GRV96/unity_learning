using UnityEngine;

public class AutoMovable: MonoBehaviour {
	private Rigidbody _rigidbody = null;
	private Vector3 _positionDelta;

	protected void Init(
			float pSpeed,
			bool pUseGravity,
			RigidbodyConstraints? pConstraints=null) {
		_rigidbody = gameObject.GetComponent<Rigidbody>();
		if(_rigidbody == null) {
			_rigidbody = gameObject.AddComponent<Rigidbody>();
		}
		_rigidbody.useGravity = pUseGravity;
		if(pConstraints != null) {
			_rigidbody.constraints = (RigidbodyConstraints) pConstraints;
		}

		_positionDelta = Vector3.forward * pSpeed;
	}

	protected void Move() {
		_rigidbody.MovePosition(
			_rigidbody.position + _positionDelta * Time.deltaTime);
	}
}
