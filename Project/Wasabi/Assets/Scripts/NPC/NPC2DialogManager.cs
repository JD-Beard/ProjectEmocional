using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC2DialogManager : MonoBehaviour {

	public GameObject textBox;
	public GameObject bridgeSwitch2;
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
			bridgeSwitch2.SetActive (true);
			currentLine = 0;

		}

	}

}