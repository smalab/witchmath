using UnityEngine;
using System.Collections;

public class Size : MonoBehaviour {

	float wide;
	float height;

	// Use this for initialization
	void Start () {

		wide=Screen.width;
		height=Screen.height;
		wide=wide/600;
		height=height/900;

		transform.localScale = new Vector3(0.1f*wide, 0.1f*height, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
