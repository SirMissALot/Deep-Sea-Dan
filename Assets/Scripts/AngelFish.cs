using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum behaviours{IDLE, CHASE};

public class AngelFish : MonoBehaviour {

	behaviours currentBehaviour = behaviours.IDLE;
	private int health = 5;
	private float speed = 1f;
	private float force = 10f;
	private bool isAttacking;
	private float atkRate = 3f;
	private float nextAtk;
	private GameObject Player;
	private SpriteRenderer spriteRenderer;
	private Rigidbody2D rgbd2D;

	void Start(){
		Player = GameObject.Find("Submarine");
		spriteRenderer = GetComponent<SpriteRenderer>();
		rgbd2D = GetComponent<Rigidbody2D>();
		isAttacking = false;
	}

	void Update(){
		switch(currentBehaviour){
			case behaviours.IDLE:
				Idle();
				break;
			case behaviours.CHASE:
				Chase();
				break;
		}	
	}

	void checkDeath(){
		if(health <= 0){
			Destroy(gameObject);
		}
	}
	void Idle(){
		if(Vector2.Distance(Player.transform.position, transform.position) < 10f) {
			currentBehaviour = behaviours.CHASE;
		}
		checkDeath();
	}
	void Chase(){
		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);

		if(Vector2.Distance(Player.transform.position, transform.position) > 3f && Time.time > nextAtk) {
			nextAtk = Time.time + atkRate;
			Attack();
		}
		checkDeath();
	}

	void Attack(){
		rgbd2D.AddForce((Player.transform.position - transform.position).normalized * force, ForceMode2D.Impulse);
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag != "Player"){
			health--;
			Debug.Log("Hit");
		}
	}

}
