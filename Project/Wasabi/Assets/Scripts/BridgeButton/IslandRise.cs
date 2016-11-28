using UnityEngine;
using System.Collections;

public class IslandRise : MonoBehaviour {

	public Animator risingIsland;
	// Use this for initialization
	void Start () {

		risingIsland = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void StartTheRise(){

		StartCoroutine (Rise ());



	}


	IEnumerator Rise(){

		yield return new WaitForSeconds (.5f);

		risingIsland.SetBool ("SetBridge", true);


	}
}
