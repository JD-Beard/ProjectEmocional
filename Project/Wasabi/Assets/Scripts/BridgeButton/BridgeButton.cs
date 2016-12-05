using UnityEngine;
using System.Collections;

public class BridgeButton : MonoBehaviour {


	public Animator buttonTrigger;
	public GameObject Bridge;
	public BridgeRise Rise;
	public AudioSource EF;
	public bool switchOn = false;
	bool IsOn = false;

	// Use this for initialization
	void Start () {

		buttonTrigger = GetComponent<Animator> ();
		//Rise = GameObject.FindGameObjectWithTag ("Bridge").GetComponent<BridgeRise> ();

	
	// Update is called once per frame
	}
	void Update () {


	
	





	
	}





	void OnTriggerEnter(Collider other){

		if(other.gameObject.CompareTag("Player")){

			if (IsOn == false) {
				buttonTrigger.SetBool ("SetTrigger", true);
				EF.Play ();
				Bridge.SetActive (true);
				Rise.MoveUp ();
				IsOn = true;

			}
		
		}




	}
}


