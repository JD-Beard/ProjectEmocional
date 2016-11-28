using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPCDialog : MonoBehaviour {
	

	public GameObject[] dialog;
	bool talkingIsOn = false;
	bool pressXToTalk = false;
	private DialogManager DManager;





	// Use this for initialization
	void Start () {

		DManager = GameObject.FindGameObjectWithTag ("GameUI").GetComponent<DialogManager> ();


	
	
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


				DManager.currentLine += 1;

			}



		}

	}


	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Player")) {

			dialog [0].SetActive (false);
			dialog [1].SetActive (false);
			talkingIsOn = false;
			pressXToTalk = false;
			DManager.currentLine = 0;
		}

	}

}
