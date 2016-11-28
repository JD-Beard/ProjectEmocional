using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeColorTree : MonoBehaviour {

	//private Animator anim;
	//public Animator tree1;
	//public Animator tree2;
	//public Animator tree3;
	//public Animator tree4;
	public GameObject[] TreeColor;
	private List<Animator> smallTree;

	// Use this for initialization
	void Start () {

		//anim = GetComponent<Animator> ();

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
		yield return new WaitForSeconds (.5f);

	

		foreach (Animator a in smallTree) {
			a.SetBool ("SetColor", true);
		}
		//anim.SetBool ("SetColor", true);
	//	tree1.SetBool ("SetColor", true);
		//tree2.SetBool ("SetColor", true);
		//tree3.SetBool ("SetColor", true);
		//tree4.SetBool ("SetColor", true);





	}


}
