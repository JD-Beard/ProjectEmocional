using UnityEngine;
using System.Collections;

public class ChangePlayerCamera : MonoBehaviour {

	public GameObject mainCamera;
	public GameObject firstPlayerCamera;
	public GameObject Player;
	bool IsCameraOFF = false;

	// Use this for initialization
	void Start () {

		IsCameraOFF = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Joystick1Button9) && IsCameraOFF == false) {


			mainCamera.SetActive (false);
			firstPlayerCamera.SetActive (true);
		    Player.SetActive (false);
			IsCameraOFF = true;

		

		} else if (Input.GetKeyDown (KeyCode.Joystick1Button9) && IsCameraOFF == true) {


			mainCamera.SetActive (true);
			firstPlayerCamera.SetActive (false);
		    Player.SetActive (true);
		//	firstPlayerCamera.transform.Rotate (0, 0, 0);
			IsCameraOFF = false;

		}





	}




	void FirstPersonCamera(){

		mainCamera.SetActive (false);
		firstPlayerCamera.SetActive (true);
		//Player.SetActive (false);
		IsCameraOFF = true;



	}


	void ThreePersonCamera(){


		mainCamera.SetActive (true);
		firstPlayerCamera.SetActive (false);
		//Player.SetActive (true);
		IsCameraOFF = false;


	}
}
