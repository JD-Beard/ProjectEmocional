using UnityEngine;
using System.Collections;

public class BridgeButton1 : MonoBehaviour {

	public Animator buttonTrigger;
	BridgeLong BRL;
	BridgeLong2 BRL2;
	public AudioSource EF;
	bool isOn = false;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		BRL= GameObject.Find ("BridgeLong").GetComponent<BridgeLong> ();
		BRL2= GameObject.Find ("BridgeLong2").GetComponent<BridgeLong2> ();


	}

	// Update is called once per frame
	void Update () {

	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.CompareTag("Player")){

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