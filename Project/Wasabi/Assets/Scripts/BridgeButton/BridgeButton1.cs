using UnityEngine;
using System.Collections;

public class BridgeButton1 : MonoBehaviour {

	public Animator buttonTrigger;
//	private BridgeLong BR;
	//private BridgeLong2 BR2;
	BridgeLong BRL;
	BridgeLong2 BRL2;
	public AudioSource EF;
	bool isOn = false;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		//BR = GameObject.FindObjectOfType<BridgeLong> ();
		//BR2 = GameObject.FindObjectOfType<BridgeLong2> ();
		BRL= GameObject.Find ("BridgeLong").GetComponent<BridgeLong> ();
		BRL2= GameObject.Find ("BridgeLong2").GetComponent<BridgeLong2> ();


	}

	// Update is called once per frame
	void Update () {

	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Player"){

			if (isOn == false) {
				buttonTrigger.SetBool ("SetTrigger", true);
				BRL.MoveUp ();
				BRL2.MoveUp ();
				EF.Play ();
				isOn = true;
			}

		}




	}
}