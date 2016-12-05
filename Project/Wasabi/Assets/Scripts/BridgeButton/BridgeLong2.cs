using UnityEngine;
using System.Collections;

public class BridgeLong2 : MonoBehaviour {

	public Animator bridgeUp;
	// Use this for initialization
	void Start () {

		bridgeUp = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

	}



	public void MoveUp(){

		StartCoroutine (StartBridge ());


	}

	IEnumerator StartBridge(){

		yield return new WaitForSeconds (.8f);
		bridgeUp.SetBool ("SetBridge", true);


	}

}