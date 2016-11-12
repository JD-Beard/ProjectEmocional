using UnityEngine;
using System.Collections;

public class ChangeColorTree : MonoBehaviour {

	private Animator anim;
	public Animator tree1;
	public Animator tree2;
	public Animator tree3;
	public Animator tree4;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {

	}

	public void StartColorChanging(){


		StartCoroutine (SetTreeColor ());

	}





	IEnumerator SetTreeColor(){
		yield return new WaitForSeconds (1);
		anim.SetBool ("SetColor", true);
		tree1.SetBool ("SetColor", true);
		tree2.SetBool ("SetColor", true);
		tree3.SetBool ("SetColor", true);
		tree4.SetBool ("SetColor", true);





	}


}
