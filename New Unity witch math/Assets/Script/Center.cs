﻿using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class Center : MonoBehaviour {

	public GameObject CenterPlus;
	public GameObject button;
	public Vector3[] CenterPos= new Vector3[3];
	public int[] cells = {0,0,0};
	private GameObject attack;

	// Use this for initialization
	void Start () {


		CenterPlus = (GameObject)Resources.Load ("Prefab/Cube");
		button = (GameObject)Resources.Load ("Prefab/AttackButton");
		GameObject s;
	
		s=Instantiate(CenterPlus, new Vector3(-1.0f, 1.0f, 0), Quaternion.identity)as GameObject;
		CenterPos[0]=s.transform.position;
		s=Instantiate(CenterPlus, new Vector3(0.0f, 1.0f, 0), Quaternion.identity)as GameObject;
		CenterPos[1]=s.transform.position;
		s=Instantiate(CenterPlus, new Vector3(1.0f, 1.0f, 0), Quaternion.identity)as GameObject;
		CenterPos[2]=s.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int GetEmpty(){

		int emp=0;

		for(int i=0;i<3;i++){

			emp=i+1;

			if(cells[i]==0)break;

			emp=0;

		}

		return emp;

	}

	public Vector3 SetEmptyCell(int bulletNum,Vector3 homePosition){

		int empty;

		empty=GetEmpty();



		if(empty!=0){

		    cells[empty-1]=bulletNum;

			Debug.Log(cells[0]);
			Debug.Log(cells[1]);
			Debug.Log(cells[2]);

			if(AttackBool()){
				attack =Instantiate(button, new Vector3(0, 3.5f, 0), Quaternion.Euler(0f,0f,0f))as GameObject;
			}
		    return CenterPos[empty-1];

		}else{
			//Debug.Log(cells[0]);
			//return homePosition;
			return Vector3.zero;
		}
	}

	public void RemoveCell(int bulletNum){

		cells[Array.FindIndex(cells, w => w == bulletNum)]=0;

		if(!AttackBool()){
			Destroy(attack);
		}

		Debug.Log(cells[0]);
		Debug.Log(cells[1]);
		Debug.Log(cells[2]);

	}

	private bool AttackBool(){
		/*int sum=0;
		for(int i=0;i<3;i++){
			if(cells[i]!=0)
				sum++;
		}*/
		if(Array.FindAll(cells, w => w != 0).Length==2){
			return true;
		}else{
			return false;
		}

	}

	public int SumCenter(){
		/*int sum=0;
		for(int i=0;i<3;i++){
				sum+=cells[i];
		}
		return sum;
		*/

		return cells.Sum();


	}



}
