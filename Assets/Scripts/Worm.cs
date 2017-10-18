using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour {

	// Use this for initialization
	Vector2 numb;
	Vector2 bumnl;

	void Start () {
		numb = GetComponent<SpriteRenderer>().sprite.rect.size;
		bumnl = numb/GetComponent<SpriteRenderer>().sprite.pixelsPerUnit;
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(bumnl);
	}
}
