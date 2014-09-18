using UnityEngine;
using System.Collections;

public class BulletMaster : MonoBehaviour {



	public GameObject CenterPlus;
	public GameObject UnderNum;

	int[] rndArray = new int[9] ;
	GameObject[] bulletArray= new GameObject[9];
	     
	// Use this for initialization
	void Start () {

		int rnd;
		for(int i=1;i<10;i++){


			do{
			   rnd=Random.Range (0, 9);

			}while(rndArray[rnd]!=0);

			rndArray[rnd]=i;

		}


		Instantiate(CenterPlus, new Vector3(0.23f, 0.4f, 0), Quaternion.identity);
		Instantiate(CenterPlus, new Vector3(0.43f, 0.4f, 0), Quaternion.identity);
		Instantiate(CenterPlus, new Vector3(0.63f, 0.4f, 0), Quaternion.identity);

		float bulletPos=0.03f;

		for(int i=0;i<9;i++){

	        if(i%2==0){

				GameObject num =Instantiate(UnderNum, new Vector3(bulletPos+(i/10f), 0.2f, 0), Quaternion.identity)as GameObject;
				Bullet b = num.GetComponent<Bullet>();
				b.bulletValue=rndArray[i];
				bulletArray[i]=num;

			}else{

				GameObject num =Instantiate(UnderNum, new Vector3(bulletPos+(i/10f), 0.1f, 0), Quaternion.identity)as GameObject;
				Bullet b = num.GetComponent<Bullet>();
				b.bulletValue=rndArray[i];
				bulletArray[i]=num;
			}

		}

	

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
