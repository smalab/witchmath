using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class BulletMaster : MonoBehaviour {
	
	public GameObject[] UnderNum =new GameObject[10];
	public GameObject parent;

	int[] rndArray = new int[9] ;
	GameObject[] bulletArray= new GameObject[9];
	     
	// Use this for initialization
	void Start () {

        var random = new System.Random();
        var rndArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.OrderBy(_ => random.NextDouble()).Take(9).ToArray();


		for(int i=0;i<9;i++){

	        if(i%2==0){

				GameObject num =Instantiate(UnderNum[rndArray[i]], new Vector3(-2f+i/2f, -1.0f, 0), Quaternion.Euler(0f,180f,0f))as GameObject;
				Bullet b = num.GetComponent<Bullet>();
				b.bulletValue=rndArray[i];
				bulletArray[i]=num;

			}else{

				GameObject num =Instantiate(UnderNum[rndArray[i]], new Vector3(-2f+i/2f, -2.0f, 0), Quaternion.Euler(0f,180f,0f))as GameObject;
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
