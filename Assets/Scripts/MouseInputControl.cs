using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputControl : MonoBehaviour {

    public float speed = 1.5f;
    private Vector3 mousePos;
    private Vector3 targetPos;
    private bool isActive;
    private PoolManager pm;

     void Awake(){
        isActive = false;
        pm = GameObject.Find("BulletHolder").GetComponent<PoolManager>();
    }
     
     void Update () {
            if (Input.GetMouseButtonDown(0)) {

                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = transform.position.z;
                isActive = true;
            }

            if (Input.GetMouseButtonDown(1)){

                targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                targetPos.z = transform.position.z;

                //--------------------------------
                // TODO: Check if it breaks somewhere
                //--------------------------------
                if(transform.position.magnitude > targetPos.magnitude){
                   
                    pm.bulletPool[pm.currentBullet].GetComponent<Bullet>().Fire(transform, (targetPos - transform.position).normalized);

                }

                else{
                    
                    pm.bulletPool[pm.currentBullet].GetComponent<Bullet>().Fire(transform, -(transform.position - targetPos).normalized);
                  
                }
                //--------------------------------
                 pm.currentBullet++;
                    if(pm.currentBullet >= pm.poolAmount){
                       pm.currentBullet = 0;
                   }
            }

        if(isActive){
            transform.position = Vector3.MoveTowards(transform.position, mousePos, speed * Time.deltaTime);
        }

     }
}
