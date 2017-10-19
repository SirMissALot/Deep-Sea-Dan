using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worm : MonoBehaviour {

	public int health = 10;
	private Animator anim;
	private Sprite currentSprite;

	void Start(){
		currentSprite = GetComponent<Sprite>();
		anim = GetComponent<Animator>();
	}

	void Update(){
		if(health <= 0){
			Destroy(gameObject);
		}
		if(currentSprite != GetComponent<SpriteRenderer>().sprite){
  			currentSprite = GetComponent<SpriteRenderer>().sprite;
			updateCollider();
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		health--;
		Debug.Log("Hit");
	}

	void animationEnd(){
		anim.SetBool("isAttacking", false);
	}

	void updateCollider(){
		gameObject.GetComponent<BoxCollider2D>().size = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
		gameObject.GetComponent<BoxCollider2D>().offset = gameObject.GetComponent<SpriteRenderer>().sprite.bounds.center;
	}

}
