using UnityEngine;
using System.Collections;

public class ChangePlayerCamera : MonoBehaviour {

	public GameObject mainCamera;
	public GameObject firstPlayerCamera;
	public GameObject Player;
	bool IsCameraOFF = false;
	public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter ThirdPersonControl;



	// Use this for initialization
	 void Start () {

		IsCameraOFF = false;
		ThirdPersonControl = GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ();


	
	}
	
	// Update is called once per frame
	void Update () {





		if (Input.GetKeyDown (KeyCode.Joystick1Button9) && IsCameraOFF == false) {


			mainCamera.SetActive (false);
			firstPlayerCamera.SetActive (true);
		    Player.SetActive (false);
			IsCameraOFF = true;
			ThirdPersonControl.m_MoveSpeedMultiplier = 0f;
			ThirdPersonControl.m_MovingTurnSpeed= 0f;
			ThirdPersonControl.m_StationaryTurnSpeed = 0f;
			ThirdPersonControl.m_JumpPower = 0f;

		

		} else if (Input.GetKeyDown (KeyCode.Joystick1Button9) && IsCameraOFF == true) {


			mainCamera.SetActive (true);
			firstPlayerCamera.SetActive (false);
		    Player.SetActive (true);
			IsCameraOFF = false;

			ThirdPersonControl.m_MoveSpeedMultiplier = 8f;
			ThirdPersonControl.m_MovingTurnSpeed= 360f;
			ThirdPersonControl.m_StationaryTurnSpeed = 180f;
			ThirdPersonControl.m_JumpPower = 8f;



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
