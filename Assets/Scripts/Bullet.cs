using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private float speed = 10f;
	private bool isActive;
	private Vector2 direction;
	private Vector2 origPos;
	private Quaternion origRot;

	void Awake(){
		isActive = false;
		origPos = transform.position;
		origRot = transform.rotation;
	}
	void Update(){
		if(isActive){
			transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
			transform.Translate(direction * speed * Time.deltaTime, Space.World);
		}
	}
	public void Fire(Transform Player, Vector2 shootDir){
		transform.position = Player.position;
		direction = shootDir;
		isActive = true;
	}
	void OnTriggerEnter2D(Collider2D other){	
			isActive = false;
			transform.position = origPos;
			transform.rotation = origRot;
	}

}
