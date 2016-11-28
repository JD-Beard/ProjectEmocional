using UnityEngine;
using System.Collections;

public class NPC3Dialog : MonoBehaviour {

	public GameObject[] dialog;
	bool talkingIsOn = false;
	bool pressXToTalk = false;
	private NPC3DialogManager D3Manager;





	// Use this for initialization
	void Start () {

		D3Manager = GameObject.FindGameObjectWithTag ("NPC3Manager").GetComponent<NPC3DialogManager> ();




	}

	// Update is called once per frame
	void Update () {




	}








	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {

			if (talkingIsOn == false) {
				dialog [0].SetActive (true);

			}
		}

	}



	void OnTriggerStay(Collider other){

		if (other.gameObject.CompareTag ("Player")) {

			if (Input.GetKeyDown(KeyCode.Joystick1Button2)&& pressXToTalk == false) {


				talkingIsOn = true;
				dialog [0].SetActive (false);
				dialog [1].SetActive (true); 
				pressXToTalk = true;



			}

			if (Input.GetButtonDown("Press X") && pressXToTalk == true) {


				D3Manager.currentLine += 1;

			}



		}

	}


	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Player")) {

			dialog [0].SetActive (false);
			dialog [1].SetActive (false);
			talkingIsOn = false;
			pressXToTalk = false;
			D3Manager.currentLine = 0;
		}

	}

}
