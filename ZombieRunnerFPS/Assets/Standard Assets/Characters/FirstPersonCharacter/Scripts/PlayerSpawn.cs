﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour {

    public Transform playerSpawnPoints;     // parent of spawn points
    public bool reSpawn = false;

    private Transform[] spawnPoints;
    private bool lastToggle = false;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(spawnPoints.Length);
	}
	
	// Update is called once per frame
	void Update () {
        if (lastToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        }
        else {
            lastToggle = reSpawn;
        }
	}

    private void Respawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].transform.position;
    }
}
