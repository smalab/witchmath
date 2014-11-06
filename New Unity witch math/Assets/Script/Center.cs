using UnityEngine;
using System.Collections;

public class Center : MonoBehaviour {

	public GameObject CenterPlus;
	public GameObject button;
	public Vector3[] CenterPos= new Vector3[3];
	public int[] cells = {0,0,0};
	private GameObject attack;

	// Use this for initialization
	void Start () {

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

	public Vector3 SetEmptyCell(int num,Vector3 home){

		int emp;

		emp=GetEmpty();



		if(emp!=0){

		    cells[emp-1]=num;

			Debug.Log(cells[0]);
			Debug.Log(cells[1]);
			Debug.Log(cells[2]);

			if(AttackBool()){
				attack =Instantiate(button, new Vector3(0, 3.5f, 0), Quaternion.Euler(0f,0f,0f))as GameObject;
			}
		    return CenterPos[emp-1];

		}else{
			//Debug.Log(cells[0]);
			return home;
		}
	}

	public void RemoveCell(int num){
		int emp;
		int i;
		
		for(i=0;i<3;i++){
			if(num==cells[i])break;
		}

		cells[i]=0;

		if(!AttackBool()){
			Destroy(attack);
		}

		Debug.Log(cells[0]);
		Debug.Log(cells[1]);
		Debug.Log(cells[2]);

	}

	private bool AttackBool(){
		int sum=0;
		for(int i=0;i<3;i++){
			if(cells[i]!=0)
				sum++;
		}
		if(sum==2){
			return true;
		}else{
			return false;
		}

	}




}
