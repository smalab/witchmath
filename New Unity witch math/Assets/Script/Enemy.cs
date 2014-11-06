using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	public GameObject[] enemyNum =new GameObject[10];
	public int enemyPoint ;

	void Start () {
		enemyPoint=Random.Range (6, 24);

		//2.2 0.3
		if(enemyPoint>=10){
			GameObject num10 =Instantiate(enemyNum[enemyPoint/10], new Vector3(-0.3f, 2.2f, 0f), Quaternion.Euler(0f,180f,0f))as GameObject;
			GameObject num1 =Instantiate(enemyNum[enemyPoint%10], new Vector3(0.3f, 2.2f, 0f), Quaternion.Euler(0f,180f,0f))as GameObject;
		}else{
			GameObject num1 =Instantiate(enemyNum[enemyPoint], new Vector3(0f, 2.2f, 0f), Quaternion.Euler(0f,180f,0f))as GameObject;
			
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Attack(){
	}
}
