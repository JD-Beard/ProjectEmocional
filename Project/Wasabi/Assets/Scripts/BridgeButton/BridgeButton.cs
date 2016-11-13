using UnityEngine;
using System.Collections;

public class BridgeButton : MonoBehaviour {


	public Animator buttonTrigger;
	private BridgeRise BR;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		BR = GameObject.FindObjectOfType<BridgeRise> ();
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Player"){


			buttonTrigger.SetBool ("SetTrigger", true);
			BR.MoveUp ();
		
		}




	}
}


