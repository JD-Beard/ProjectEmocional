using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {
	public float spinSpeed;
	public ParticleSystem changeEffect;
	public GameObject NPC2Wolf;
	ChangeColorTree treeEffect;


	private Rigidbody RB;
	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody> ();
		treeEffect = FindObjectOfType<ChangeColorTree> ();

	
	}
	
	// Update is called once per frame
	void Update () {

		RB.transform.Rotate (Vector3.up * Time.deltaTime *spinSpeed,Space.World);
	
	}




	void OnCollisionEnter(Collision other){


		if (other.collider.gameObject.tag == "Player") {

			gameObject.SetActive (false);
			Instantiate (changeEffect, transform.position, transform.rotation);
			treeEffect.StartColorChanging ();
			NPC2Wolf.SetActive (true);




		}




	}


}
