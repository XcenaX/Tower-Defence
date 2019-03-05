using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaveSpawn : MonoBehaviour
{

    [SerializeField]
    private int waveSize;
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private float enemyInterval;  
    [SerializeField] 
    private Transform spawnPoint;
    [SerializeField]
    private int startTime;
    [SerializeField]
    private Vector3 offset;
    private int enemyCount= 0;    
    [SerializeField]
    public Transform[] WayPoints;
 
    private void Start()
    {
        InvokeRepeating("SpawnEnemy",startTime,enemyInterval);
    }     

    public void SpawnEnemy(){
        enemyCount++;
        GameObject enemy = GameObject.Instantiate(enemyPrefab,spawnPoint.position + offset, Quaternion.identity) as GameObject;
        enemy.GetComponent<MoveToWayPoints>().wayPoints = WayPoints;        
    }

    private void Update(){
        if(enemyCount == waveSize){
            CancelInvoke("SpawnEnemy");
        }
    }
}
