using UnityEngine;
using System.Collections;

public class Bullet: MonoBehaviour {

	public GUIText myText;  
	public int bulletValue;
	public Vector3 startVector;
	public Vector3 goalVector;
	public int state = 1;
	public GameObject CT;
	
	// Use this for initialization
	void Start () {

		startVector = this.transform.position;
		myText.text = ""+bulletValue;	
		
	}
	// Use this for initialization

	// Update is called once per frame
	void Update () {


	
	}

	void SlideUp(){



	}

	void SlideDown(){

	}
}
