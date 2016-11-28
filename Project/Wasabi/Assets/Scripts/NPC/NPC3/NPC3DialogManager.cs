using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NPC3DialogManager : MonoBehaviour {

	public GameObject textBox;
	public GameObject bridgeSwitch3;
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
			bridgeSwitch3.SetActive (true);
			currentLine = 0;

		}

	}

}