using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelFish : MonoBehaviour {

	public int health = 10;

	void Update(){
		if(health <= 0){
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		health--;
		Debug.Log("Hit");
	}
}
