using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Rotating2 : MonoBehaviour {

	public float spinSpeed;
	public ParticleSystem changeEffect;
	BeginChangeColor treeEffect;
	IslandRise islandEffect;

	private Rigidbody RB;
	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody> ();
		treeEffect = FindObjectOfType<BeginChangeColor> ();
		islandEffect = FindObjectOfType<IslandRise> ();

	}

	// Update is called once per frame
	void Update () {

		RB.transform.Rotate (Vector3.up * Time.deltaTime *spinSpeed,Space.World);

	}




	void OnCollisionEnter(Collision other){


		if (other.collider.gameObject.CompareTag("Player")) {

			gameObject.SetActive (false);
			Instantiate (changeEffect, transform.position, transform.rotation);
			treeEffect.StartColorChanging ();
			islandEffect.StartTheRise ();

		}




	}



}
