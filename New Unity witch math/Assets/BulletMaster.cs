using UnityEngine;
using System.Collections;

public class BulletMaster : MonoBehaviour {



	public GameObject CenterPlus;
	public GameObject UnderNum;

	public static int CenterNum=3;

	// Use this for initialization
	void Start () {

		Instantiate(CenterPlus, new Vector3(0.23f, 0.4f, 0), Quaternion.identity);

		if(CenterNum==3)
		Instantiate(CenterPlus, new Vector3(0.43f, 0.4f, 0), Quaternion.identity);

		Instantiate(CenterPlus, new Vector3(0.63f, 0.4f, 0), Quaternion.identity);


		GameObject num1 =Instantiate(UnderNum, new Vector3(0.03f, 0.2f, 0), Quaternion.identity)as GameObject;
		Bullet b = num1.GetComponent<Bullet>();
		b.k=1;
	
	
		Instantiate(UnderNum, new Vector3(0.23f, 0.2f, 0), Quaternion.identity);
		Instantiate(UnderNum, new Vector3(0.43f, 0.2f, 0), Quaternion.identity);
		Instantiate(UnderNum, new Vector3(0.63f, 0.2f, 0), Quaternion.identity);
		Instantiate(UnderNum, new Vector3(0.83f, 0.2f, 0), Quaternion.identity);


		Instantiate(UnderNum, new Vector3(0.13f, 0.1f, 0), Quaternion.identity);
		Instantiate(UnderNum, new Vector3(0.33f, 0.1f, 0), Quaternion.identity);
		Instantiate(UnderNum, new Vector3(0.53f, 0.1f, 0), Quaternion.identity);
		Instantiate(UnderNum, new Vector3(0.73f, 0.1f, 0), Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
