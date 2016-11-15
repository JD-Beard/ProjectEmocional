using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class BigColorChange : MonoBehaviour {

	public GameObject[] TreeColor;
	private List<Animator> smallTree;



	// Use this for initialization
	void Start () {



		smallTree = new List<Animator> ();

		for (int i = 0; i < TreeColor.Length; i++) {

			smallTree.Add(TreeColor[i].GetComponent<Animator>());


		}

	}

	// Update is called once per frame
	void Update () {

	}

	public void StartColorChanging(){


		StartCoroutine (SetTreeColor ());

	}





	IEnumerator SetTreeColor(){
		yield return new WaitForSeconds (1);
		foreach (Animator a in smallTree) {
			a.SetBool ("SetColor", true);
		}
//		for (int i = 0; i < TreeColor.Length; i++) {
//
//			TreeColor [i].GetComponent<Animator> ().SetBool ("SetColor", true);
//		}

		yield return new WaitForSeconds (6);


		SceneManager.LoadScene ("Gameover");

	}


}
