using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bullet: MonoBehaviour {

	public Text myText;  
	public int bulletValue;
	public Vector3 startVector;
	public Vector3 goalVector;
	public int state = 1;
	public GameObject CT;
	private float screenPoint1;
	private float screenPoint2;
	// Use this for initialization
	void Start () {

		startVector = this.transform.position;
		myText.text = ""+bulletValue;	
		
	}
	// Use this for initialization

	// Update is called once per frame
	void Update () {


	
	}

	
	void OnMouseDown() {

		screenPoint1 = Input.mousePosition.y;
		Debug.Log("down");

	}
	

	void OnMouseUp() {
		Debug.Log("up");
		screenPoint2 = Input.mousePosition.y;
		if(screenPoint1<screenPoint2){
			SlideUp();
		}
	}



	void SlideUp(){

		Debug.Log("OK");

	}

	void SlideDown(){

	}
}
