﻿using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

		GameObject CT = GameObject.Find("GameCT");
		Enemy enemy = CT.GetComponent<Enemy>();
		enemy.Attack();

		Debug.Log("Attack");
		Destroy(gameObject);
		Destroy(this);
		
	}
}
