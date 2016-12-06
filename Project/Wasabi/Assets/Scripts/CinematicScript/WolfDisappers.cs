using UnityEngine;
using System.Collections;

public class WolfDisappers : MonoBehaviour {


	public ParticleSystem PSEffect;
	public GameObject PortalCrystal;
	public Transform posForEffect;
	AnimationScene animScene;


	// Use this for initialization
	void Start () {

		animScene = GameObject.Find ("TriggerScene").GetComponent<AnimationScene> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void StartAction(){


		StartCoroutine (Disappear ());

	}


	IEnumerator Disappear(){


		yield return new WaitForSeconds (1f);
		Instantiate (PSEffect, posForEffect.transform.position, posForEffect.transform.rotation);

		yield return new WaitForSeconds (5f);
		animScene.BringplayerCamera ();
		PortalCrystal.SetActive (true);
		this.gameObject.SetActive (false);
	



	}
}
