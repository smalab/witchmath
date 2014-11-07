using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	public GameObject[] enemyNum =new GameObject[10];
	public int enemyPoint ;
	public bool win=false;
	public bool bulletEnd=false;
	private int damageCount=0;
	GameObject num10;
	GameObject num1;
	

	
	void Start () {
		enemyPoint=Random.Range (6, 24);
		enemyNum[0] = (GameObject)Resources.Load ("Prefab/0");
		enemyNum[1] = (GameObject)Resources.Load ("Prefab/1");
		enemyNum[2] = (GameObject)Resources.Load ("Prefab/2");
		enemyNum[3] = (GameObject)Resources.Load ("Prefab/3");
		enemyNum[4] = (GameObject)Resources.Load ("Prefab/4");
		enemyNum[5] = (GameObject)Resources.Load ("Prefab/5");
		enemyNum[6] = (GameObject)Resources.Load ("Prefab/6");
		enemyNum[7] = (GameObject)Resources.Load ("Prefab/7");
		enemyNum[8] = (GameObject)Resources.Load ("Prefab/8");
		enemyNum[9] = (GameObject)Resources.Load ("Prefab/9");
		//2.2 0.3
		if(enemyPoint>=10){
		    num10 =Instantiate(enemyNum[enemyPoint/10], new Vector3(-0.3f, 2.2f, 0f), Quaternion.Euler(0f,180f,0f))as GameObject;
			num1 =Instantiate(enemyNum[enemyPoint%10], new Vector3(0.3f, 2.2f, 0f), Quaternion.Euler(0f,180f,0f))as GameObject;
		}else{
			num1 =Instantiate(enemyNum[enemyPoint], new Vector3(0f, 2.2f, 0f), Quaternion.Euler(0f,180f,0f))as GameObject;
			
		}

	}

	public void EnemyDestroy(){
		if(enemyPoint>=10){
			Destroy(num10);
			Destroy (num1);
		}else{
			Destroy (num1);
		}

	}
	
	// Update is called once per frame
	void Update () {

		if(damageCount==0&&bulletEnd==true){
			Damage();
			damageCount=1;
		}
	
	}

	public void Attacked(){
	
		GameObject CT = GameObject.Find("BulletCT");
		BulletMaster master = CT.GetComponent<BulletMaster>();
		master.LockBullet();
		master.MoveCenter();
		Center center = CT.GetComponent<Center>();
		int sum=center.SumCenter();
		if(sum==enemyPoint){
			Debug.Log("win");
			win=true;
		}else{
			Debug.Log("lose");
			win=false;
		}

	}

	void Damage(){
		Debug.Log ("Damage");
		GameObject CT = GameObject.Find("GameCT");
		GameCT gmct = CT.GetComponent<GameCT>();
		if(win){
			gmct.win(enemyPoint);
		}else{

			gmct.lose(enemyPoint);
		}
	}


}
