using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

	public GameObject textBox;
	public GameObject bridgeSwitch;
	public Text dialog;
	public TextAsset textFile;
	public string[] textLines;
	public int currentLine;
	public int endAtLine;
	//private UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter ThirdPersonControl;

	// Use this for initialization
	void Start () {


		//ThirdPersonControl = GameObject.FindGameObjectWithTag ("Player").GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter> ();
	

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
			bridgeSwitch.SetActive (true);
			currentLine = 0;
//			ThirdPersonControl.m_MoveSpeedMultiplier = 8f;
//			ThirdPersonControl.m_MovingTurnSpeed= 360f;
//			ThirdPersonControl.m_StationaryTurnSpeed = 180f;
//			ThirdPersonControl.m_JumpPower = 8f;
//			ThirdPersonControl.canMove = true;
//
		}

	}

}