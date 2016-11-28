using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC4DialogManager : MonoBehaviour {

	public GameObject textBox;
	public Text dialog;
	public TextAsset textFile;
	public string[] textLines;
	public int currentLine;
	public int endAtLine;

	// Use this for initialization
	void Start () {



		if (textFile != null) {

			textLines = (textFile.text.Split ('\n'));

		}


		if (endAtLine == 0) {

			endAtLine = textLines.Length - 1;

		}

	}

	void Update(){


		dialog.text = textLines [currentLine];



		if (currentLine > endAtLine) {
			textBox.SetActive (false);
			currentLine = 0;
			StartGameOver ();

		}

	}


	void StartGameOver(){

		StartCoroutine (GameOver ());

	}

	IEnumerator GameOver(){

		yield return new WaitForSeconds (2);

		SceneManager.LoadScene ("GameOver");


	}

}