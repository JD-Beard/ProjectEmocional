using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnimationScene : MonoBehaviour {

	public GameObject playerCamera;
	public GameObject sceneCamera;
	public Animator scAnim;
	WolfDisappers disappers;
	public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter THPlayer;
	bool isOn = false;

	// Use this for initialization
	void Start () {

		disappers = GameObject.FindGameObjectWithTag ("Talking").GetComponent<WolfDisappers> ();
		THPlayer = GameObject.Find("Player").GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void BringplayerCamera(){

		StartCoroutine (TurnCamera ());

	}

	public void LoadScene(){

		StartCoroutine (StartScene ());

	}


	IEnumerator StartScene(){

		yield return new WaitForSeconds (2.5f);
		SceneManager.LoadScene ("Level01");


	}


	IEnumerator TurnCamera(){

		yield return new WaitForSeconds (.2f);
		sceneCamera.SetActive (false);
		playerCamera.SetActive (true);
		THPlayer.canMove = true;


	}






	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Player")) {

			if (isOn == false) {
				playerCamera.SetActive (false);
				sceneCamera.SetActive (true);
				scAnim.SetBool ("StartCamera", true);
				THPlayer.canMove = false;
				disappers.StartAction ();
				isOn = true;


			}
		}



	}
}
