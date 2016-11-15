using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene(int SceneToChangeTo){

		if (Input.GetKeyDown (KeyCode.Joystick1Button2)) {
			SceneManager.LoadScene (SceneToChangeTo);

		}
	}
}
