using UnityEngine;
using System.Collections;

public class BridgeButton1 : MonoBehaviour {

	public Animator buttonTrigger;
	private BridgeLong BR;
	private BridgeLong2 BR2;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		BR = GameObject.FindObjectOfType<BridgeLong> ();
		BR2 = GameObject.FindObjectOfType<BridgeLong2> ();


	}

	// Update is called once per frame
	void Update () {

	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Player"){


			buttonTrigger.SetBool ("SetTrigger", true);
			BR.MoveUp ();
			BR2.MoveUp ();

		}




	}
}