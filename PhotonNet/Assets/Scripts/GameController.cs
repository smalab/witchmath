using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	private PhotonView myPV;


	void Start()
	{
		myPV = PhotonView.Get(this);
		//if(!myPV.isMine){
		//	this.enabled = false;
		//}
	}
	
	void Update()
	{
		if (myPV.isMine)
		{
			float x = Input.GetAxis("Horizontal");
			float z = Input.GetAxis("Vertical");
			transform.Translate(x * 0.2f, 0, z * 0.2f);
		}


		myPV.RPC("move",PhotonTargets.All,this.transform.position);
	}


	[RPC]
	void move(Vector3 a){
		transform.position = a;
	}




}