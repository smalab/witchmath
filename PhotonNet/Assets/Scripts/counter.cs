using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class counter : MonoBehaviour {

	//public int count=0;
	private PhotonView photon;
	public GameObject obj;
	private static int count = 0;
	private PhotonView myPV;

	// Use this for initialization
	void Start () {
		//photonViewを取得し、自分のオブジェクトでなければスクリプト停止
		myPV = PhotonView.Get(this);
		if(!myPV.isMine){
			this.enabled = false;
		}
	}

	public void up (){
		count += 1;
		myPV.RPC("addScore",PhotonTargets.All,count);
	}

	// Update is called once per frame
	void Update () {

	}

	[RPC]
	void addScore(int score){
		count = score;
		Text hoge = obj.GetComponent<Text>();
		hoge.text = count+"";
	}
}
