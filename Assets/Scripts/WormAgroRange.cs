using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormAgroRange : MonoBehaviour {

	private Worm worm;

	void Start(){
		worm = GameObject.Find("Worm").GetComponent<Worm>();
	}
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("Player");
		worm.GetComponent<Animator>().SetBool("isAttacking", true);
	}
}
