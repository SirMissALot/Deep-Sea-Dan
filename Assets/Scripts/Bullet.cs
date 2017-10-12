using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private float speed = 10f;
	public bool isActive;
	private Vector3 direction;
	void Awake(){
		isActive = false;
	}
	void Update(){
		if(isActive){
			transform.Translate(direction * speed * Time.deltaTime);
		}
	}

	public void Fire(Transform Player, Vector3 shootDir){
		transform.position = Player.position;
		direction = shootDir;
		isActive = true;
	}

	void OnCollisionEnter2D(Collision2D other){
		
	}
}
