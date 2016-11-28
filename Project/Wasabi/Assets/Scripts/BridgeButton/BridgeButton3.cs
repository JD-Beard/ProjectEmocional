using UnityEngine;
using System.Collections;

public class BridgeButton3 : MonoBehaviour {

	public Animator buttonTrigger;

	public AudioSource EF;
	bool isOn = false;
	IslandRise islandEffect;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		islandEffect = FindObjectOfType<IslandRise> ();



	}

	// Update is called once per frame
	void Update () {

	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.CompareTag("Player")){

			if (isOn == false) {
				buttonTrigger.SetBool ("SetTrigger", true);
				islandEffect.StartTheRise ();
				EF.Play ();
				isOn = true;
			}

		}




	}
}