using UnityEngine;
using System.Collections;

public class DestroyParticle : MonoBehaviour {


	public AudioSource soundEffect;
	// Use this for initialization
	void Start () {
		soundEffect.Play ();
		Destroy (gameObject, 4f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
