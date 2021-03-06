﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bullet: MonoBehaviour {


	public int bulletValue;
	public Vector3 startVector;
	public Vector3 goalVector;
	public Vector3 endVector=new Vector3(0f, 2.2f, 0f);
	public int state = 1;
	private float  speed=0.3f;
	private float screenPoint1;
	private float screenPoint2;
	private bool bulletMove=false;
	private bool bulletAttackMove=false;
	private bool helthUpEvent=false;
	private GameObject clone;
	public GameObject helthPrefab;

	void Start () {
		startVector = this.transform.position;
	}

	void Update () {
	
	}
	
	void OnMouseDown() {
		screenPoint1 = Input.mousePosition.y;
		Debug.Log("down");
	}

	void OnMouseUp() {
		Debug.Log("up");
		screenPoint2 = Input.mousePosition.y;
		if(screenPoint1<screenPoint2&&state==1){
			SlideUp();
		}
		if(screenPoint1>screenPoint2&&state==2){
			SlideDown();
		}
	}
	
	void SlideUp(){
	    GameObject CT = GameObject.Find("BulletCT");
		Center center = CT.GetComponent<Center>();
		goalVector=center.SetEmptyCell(bulletValue,startVector);
		Debug.Log(goalVector);
		//if(goalVector!=startVector){
		if(goalVector!=Vector3.zero){
			StartCoroutine(MoveCoroutine());
			//bulletMove=true;
			state=2;
		}
	}

	void SlideDown(){
		GameObject CT = GameObject.Find("BulletCT");
		Center center = CT.GetComponent<Center>();
		center.RemoveCell(bulletValue);
		goalVector=startVector;
		Debug.Log(goalVector);
		StartCoroutine(MoveCoroutine());
		//bulletMove=true;
		state=1;
	}

	public void MoveToCenter(){
		StartCoroutine(AttackMoveCoroutine());
	}

	public void AttackState(){
		state=3;
	}

	public void HelthUpEvent(){
		helthUpEvent=true;
		Debug.Log("BulletHelthEventOK");
		//複製したプレハブをGameObjectに型キャストして入れます
		clone = (GameObject) Instantiate(helthPrefab, this.transform.position, Quaternion.identity);
		//親オブジェクトの指定はこんな感じでできます。これを以下プレハブ複製箇所に全部適応
		clone.transform.parent = this.transform;
	}

	IEnumerator MoveCoroutine(){
		while(true){
			transform.position = Vector3.MoveTowards (transform.position , goalVector , speed);
			if(this.transform.position==goalVector){
				yield break;
			}
			yield return new WaitForSeconds(0.01f);
		}
	}

	IEnumerator AttackMoveCoroutine(){
		while(true){
			transform.position = Vector3.MoveTowards (transform.position , endVector , speed);
			if(this.transform.position==endVector){
				bulletAttackMove=false;
				
				GameObject CT = GameObject.Find("EnemyCT");
				Enemy em = CT.GetComponent<Enemy>();
				em.SetDamage();
				
				Destroy(gameObject);
			}
			yield return new WaitForSeconds(0.01f);
		}
	}
	
}
