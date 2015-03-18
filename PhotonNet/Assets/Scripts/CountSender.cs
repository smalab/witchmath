using UnityEngine;
using System.Collections;

public class CountSender : Photon.MonoBehaviour
{
/*	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		if (stream.isWriting) {
			//データの送信
			counter send = GetComponent<counter>();
			stream.SendNext(send.count);

		} else {
			//データの受信
			int a = (int)stream.ReceiveNext();
			counter rec = GetComponent<counter>();
			rec.count=a;
		}
	}

*/
}