using UnityEngine;
using System.Collections;

public class FirstPersonCamera : MonoBehaviour {


	public float Hspeed = 2.0f;
	public float Vspeed = 2.0f;
	public float yaw = 0.0f;
	public float pitch = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		yaw += Hspeed * Input.GetAxis ("Mouse X");
		pitch -= Vspeed * Input.GetAxis ("Mouse Y");
		transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
	
	}
}
