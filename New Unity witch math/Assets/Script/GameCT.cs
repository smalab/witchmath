using UnityEngine;
using System.Collections;

public class GameCT : MonoBehaviour {


	private int PlayerHp=120;
	private int EnemyHp=120;
	public GameObject PlayerHpBer;
	public GameObject EnemyHpBer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GameEnd(){

	}

	void turnEnd(){
		if(PlayerHp==0||EnemyHp==0){
			GameEnd();
		}else{
			GameObject bCT = GameObject.Find("BulletCT");
			BulletMaster master = bCT.GetComponent<BulletMaster>();
			master.BulletDestroy();
			Destroy(master);
			Center center = bCT.GetComponent<Center>();
			Destroy(center);
			GameObject eCT = GameObject.Find("EnemyCT");
			Enemy enemy = eCT.GetComponent<Enemy>();
			enemy.EnemyDestroy();
			Destroy(enemy);
			NextGame();
		}
	}

	public void lose(int p){
		PlayerHp-=p;
		if(PlayerHp<0){
			PlayerHp=0;
		}
		PlayerHpBer.transform.localScale = new Vector3(PlayerHp/10f, 0.3f, 0.1f);
		turnEnd();
	}
	public void win(int p){
		EnemyHp-=p;
		if(EnemyHp<0){
			EnemyHp=0;
		}
		EnemyHpBer.transform.localScale = new Vector3(EnemyHp/10f, 0.3f, 0.1f);
		turnEnd();
	}

	void NextGame(){
		GameObject bCT = GameObject.Find("BulletCT");
		bCT.AddComponent(typeof(BulletMaster));
		bCT.AddComponent(typeof(Center));
		GameObject eCT = GameObject.Find("EnemyCT");
		eCT.AddComponent(typeof(Enemy));
	}
}
