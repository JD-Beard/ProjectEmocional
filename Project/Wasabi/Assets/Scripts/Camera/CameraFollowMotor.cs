  using UnityEngine;
using System.Collections;

public class CameraFollowMotor : MonoBehaviour {


	[SerializeField]
	private float distanceAway;
	[SerializeField]
	private float distanceUp;
	[SerializeField]
	private float smooth;
	[SerializeField]
	private Transform follow;
	private Vector3 targetPosition;
	private Vector3 offset = new Vector3(0f,1.5f,0f);
	private Vector3 lookDir;


	private Vector3 velocityCamSmooth = Vector3.zero;
	[SerializeField]
	private float camSmoothDampTime = 0.1f;


	public float Hspeed = 2.0f;
	public float Vspeed = 2.0f;
	public float yaw = 0.0f;
	public float pitch = 0.0f;




	// Use this for initialization
	void Start () {

		follow = GameObject.FindWithTag ("Player").transform;
	
	}
	
	// Update is called once per frame
	void Update () {




	
	}


	void LateUpdate(){




		Vector3 characterOffset = follow.position + offset;


		lookDir = characterOffset - this.transform.position;
		lookDir.y = 0;
		lookDir.Normalize ();




		targetPosition = characterOffset + follow.up * distanceUp - lookDir * distanceAway;
		smoothPosition (this.transform.position, targetPosition);



		transform.LookAt (follow);

		if (Input.GetAxis ("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) {

			yaw += Hspeed *  Input.GetAxis ("Mouse X");
			pitch -= Vspeed *  Input.GetAxis ("Mouse Y");
			transform.eulerAngles = new Vector3 (pitch, yaw+ 1.5f, 2f);


		}

	}

	private void smoothPosition(Vector3 fromPos, Vector3 toPos){

		this.transform.position = Vector3.SmoothDamp (fromPos, toPos, ref velocityCamSmooth, camSmoothDampTime);



	}


}
