using UnityEngine;
using System.Collections;

public class RayCastTarget : MonoBehaviour {

	public static float Fardistance = 5f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		RaycastHit hit;

		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit)) {

			Fardistance = hit.distance;

		}

	}
}