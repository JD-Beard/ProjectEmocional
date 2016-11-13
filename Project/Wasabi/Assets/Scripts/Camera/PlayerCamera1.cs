using UnityEngine;
using System.Collections;

public class PlayerCamera1 : MonoBehaviour {

	public float rotateSpeed = 5;
	Vector3 offset;

	void Start() {

	}

	void FixedUpdate() {
		float horizontal = Input.GetAxis ("Mouse X") * rotateSpeed;
		transform.Rotate(0, horizontal, 0);


		transform.Rotate (0, 0, 0);
	}
}