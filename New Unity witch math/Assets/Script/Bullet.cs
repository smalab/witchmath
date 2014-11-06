using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bullet: MonoBehaviour {


	public int bulletValue;
	public Vector3 startVector;
	public Vector3 goalVector;
	public int state = 1;
	private float  speed=0.1f;
	private float screenPoint1;
	private float screenPoint2;
	private bool move=false;
	// Use this for initialization
	void Start () {

		startVector = this.transform.position;
	
		
	}
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if(move==true){
			transform.position = Vector3.MoveTowards (transform.position , goalVector , speed);
			if(this.transform.position==goalVector)
				move=false;
		}
	
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
		if(goalVector!=startVector){
			move=true;
			state=2;
		}
	}

	void SlideDown(){
		GameObject CT = GameObject.Find("BulletCT");
		Center center = CT.GetComponent<Center>();
		center.RemoveCell(bulletValue);
		goalVector=startVector;
		Debug.Log(goalVector);
		move=true;
		state=1;

	}
}
