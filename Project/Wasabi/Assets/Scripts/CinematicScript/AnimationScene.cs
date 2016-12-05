using UnityEngine;
using System.Collections;

public class AnimationScene : MonoBehaviour {

	public GameObject playerCamera;
	public GameObject sceneCamera;
	public Animator scAnim;
	WolfDisappers disappers;
	public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter THPlayer;

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


	IEnumerator TurnCamera(){

		yield return new WaitForSeconds (.2f);
		sceneCamera.SetActive (false);
		playerCamera.SetActive (true);
		THPlayer.canMove = true;


	}



	void OnTriggerEnter(Collider other){

		if (other.gameObject.CompareTag ("Player")) {

			playerCamera.SetActive (false);
			sceneCamera.SetActive (true);
			scAnim.SetBool ("StartCamera", true);
			THPlayer.canMove = false;
			disappers.StartAction ();


		}



	}
}
