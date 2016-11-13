using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject ButtonTrigger;

	public Transform spawnPointA;



	void Start ()
	{

	


	}

 public	void SpawningButton ()
	{

	
		Instantiate (ButtonTrigger, spawnPointA.transform.position, spawnPointA.transform.rotation);




	}


}
