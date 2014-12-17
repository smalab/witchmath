using UnityEngine;
using System.Collections;

public class BulletMaster : MonoBehaviour {
	
	public GameObject[] UnderNum =new GameObject[10];
	public GameObject parent;
	int[] rndArray = new int[9] ;
	GameObject[] bulletArray= new GameObject[9];
	bool helthUpEventFlag=false;

	void Start () {
	
		UnderNum[0] = (GameObject)Resources.Load ("Prefab/0bullet");
		UnderNum[1] = (GameObject)Resources.Load ("Prefab/1bullet");
		UnderNum[2] = (GameObject)Resources.Load ("Prefab/2bullet");
		UnderNum[3] = (GameObject)Resources.Load ("Prefab/3bullet");
		UnderNum[4] = (GameObject)Resources.Load ("Prefab/4bullet");
		UnderNum[5] = (GameObject)Resources.Load ("Prefab/5bullet");
		UnderNum[6] = (GameObject)Resources.Load ("Prefab/6bullet");
		UnderNum[7] = (GameObject)Resources.Load ("Prefab/7bullet");
		UnderNum[8] = (GameObject)Resources.Load ("Prefab/8bullet");
		UnderNum[9] = (GameObject)Resources.Load ("Prefab/9bullet");

		int rnd;
		for(int i=1;i<10;i++){
			do{rnd=Random.Range (0, 9);}while(rndArray[rnd]!=0);
			rndArray[rnd]=i;
		}

		int helthRnd;
		helthRnd=Random.Range (0, 5);
		if(helthRnd==1)
		helthUpEventFlag=true;
	
		int helthBulletRnd=Random.Range (0, 9);

		for(int i=0;i<9;i++){

				GameObject num =Instantiate(UnderNum[rndArray[i]], new Vector3(-2f+i/2f, -0.5f-(i%2), 0), Quaternion.Euler(0f,0f,0f))as GameObject;
				bulletArray[i]=num;
				Bullet b = num.GetComponent<Bullet>();
				b.bulletValue=rndArray[i];
				bulletArray[i]=num;

				if(helthUpEventFlag){
					if(helthBulletRnd==i){
					Debug.Log("HelthUp");
					b.HelthUpEvent();
					}
				}
		}
	}

	void Update () {
	
	}

	public void LockBullet(){
		for(int i=0;i<9;i++){
			Bullet b = bulletArray[i].GetComponent<Bullet>();
			b.AttackState();
		}
	}

	public void MoveCenter(){
		GameObject CT = GameObject.Find("BulletCT");
		Center center = CT.GetComponent<Center>();
		for(int i=0;i<3;i++){
			for(int m=0;m<9;m++){
				Bullet b = bulletArray[m].GetComponent<Bullet>();
				if(	b.bulletValue==center.cells[i]){
					b.MoveToCenter();
				}
			}
		}
	}

	public void BulletDestroy(){
		for(int i=0;i<9;i++){
			Destroy(bulletArray[i]);
		}
	}
}
