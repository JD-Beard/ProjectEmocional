using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {
	public float spinSpeed;

	private Rigidbody RB;
	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		RB.transform.Rotate (Vector3.up * Time.deltaTime *spinSpeed,Space.World);
	
	}
}
