using UnityEngine;
using System.Collections;

public class BridgeButton : MonoBehaviour {


	public Animator buttonTrigger;
	//public GameObject BR;
	BridgeRise Rise;
	public AudioSource EF;
	bool IsOn = false;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		Rise = GameObject.Find ("Bridge").GetComponent<BridgeRise> ();
	// Update is called once per frame
	}
	void Update () {
	
	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.CompareTag("Player")){

			if (IsOn == false) {
				buttonTrigger.SetBool ("SetTrigger", true);
				EF.Play ();
				Rise.MoveUp ();
				IsOn = true;

			}
		
		}




	}
}


