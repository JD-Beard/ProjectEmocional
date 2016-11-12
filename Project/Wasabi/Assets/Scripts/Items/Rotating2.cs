using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Rotating2 : MonoBehaviour {

	public float spinSpeed;
	public ParticleSystem changeEffect;
	ChangeColor2 treeEffect;

	private Rigidbody RB;
	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody> ();
		treeEffect = FindObjectOfType<ChangeColor2> ();

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
			//Thankyou ();



		}




	}

//	public void Thankyou(){
//
//		StartCoroutine (StartThankyou ());
//
//	}
//
//
//
//	IEnumerator StartThankyou(){
//
//		yield return new WaitForSeconds (8);
//
//		SceneManager.LoadScene ("Gameover");
//
//
//	}


}
