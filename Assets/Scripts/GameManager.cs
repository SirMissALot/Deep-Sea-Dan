using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	 public static GameManager instance = null;

	 private int Continues;
	 private int Pearls;
	 private int Hearts;
	 private int Points;

	void Start () {
		if (instance == null){
			instance = this;
		}      
                
        else if (instance != this){
 			Destroy(gameObject); 
		}

         DontDestroyOnLoad(gameObject);
	}

	void Update () {
		
	}

	void start(){
		
	}
}
