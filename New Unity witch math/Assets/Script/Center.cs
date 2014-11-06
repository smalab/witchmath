using UnityEngine;
using System.Collections;

public class Center : MonoBehaviour {

	public GameObject CenterPlus;

	public Vector3[] CenterPos= new Vector3[3];
	public int[] cells = {0,0,0};


	// Use this for initialization
	void Start () {

		GameObject s;
	
		s=Instantiate(CenterPlus, new Vector3(-1.0f, 0.5f, 0), Quaternion.identity)as GameObject;
		CenterPos[0]=s.transform.position;
		s=Instantiate(CenterPlus, new Vector3(0.0f, 0.5f, 0), Quaternion.identity)as GameObject;
		CenterPos[1]=s.transform.position;
		s=Instantiate(CenterPlus, new Vector3(1.0f, 0.5f, 0), Quaternion.identity)as GameObject;
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

	Vector3 SetEmptyCell(int num,Vector3 home){

		int emp;

		emp=GetEmpty();

		if(emp!=0){

		    cells[emp-1]=num;

		    return CenterPos[emp-1];

		}else{

			return home;
		}
	}




}
