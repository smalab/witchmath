using UnityEngine;
using System.Collections;

public class Bullet: MonoBehaviour {
	public GUIText myText;  
	public int bulletValue =0;
	
	// Use this for initialization
	void Start () {
		
		myText.text = ""+bulletValue;	
		
	}
	// Use this for initialization

	// Update is called once per frame
	void Update () {
	
	}
}
