using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//------------------------------------------------------------------------------------------
// Pool Manager for Bullets
//------------------------------------------------------------------------------------------
public class PoolManager : MonoBehaviour {

	public GameObject[] bulletPool;
	public int poolAmount = 10;
	public int currentBullet = 0;
	private Vector3 bulletPlaceHolder;
	private Vector3 offset = new Vector3(0,0,-1.5f);
	public GameObject bullet;
	void Start(){
		bulletPool = new GameObject[poolAmount];
	
		bulletPlaceHolder = transform.position;

		for(int i = 0; i < poolAmount; i++){
             bulletPool[i] = Instantiate(bullet, bulletPlaceHolder + offset, Quaternion.identity);
			 bulletPool[i].transform.parent = gameObject.transform;
         }

	}



}

