﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour {

	private GameObject Player;
    public float moveSpeed;
    public float rotationSpeed;
    // Use this for initialization
    void Start () {
    Player = GameObject.Find("Submarine");
  }
  
  // Update is called once per frame
  void Update () {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, moveSpeed * Time.deltaTime);
        Vector3 vectorToTarget = Player.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);
    }
}
