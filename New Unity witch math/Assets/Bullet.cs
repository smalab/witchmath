﻿using UnityEngine;
using System.Collections;

public class Bullet: MonoBehaviour {
	public GUIText myText;  
	public int k =0;
	
	// Use this for initialization
	void Start () {
		
		myText.text = ""+k;	
		
	}
	// Use this for initialization

	// Update is called once per frame
	void Update () {
	
	}
}
