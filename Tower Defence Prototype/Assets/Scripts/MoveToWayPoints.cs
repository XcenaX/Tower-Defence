using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWayPoints : MonoBehaviour
{
    [SerializeField]
    private float speed;       
    public Transform[] wayPoints;
    int curWayPoint = 0;

    void Update()
    {
        if(curWayPoint < wayPoints.Length){
        transform.LookAt(wayPoints[curWayPoint].position);
        this.transform.position = Vector3.MoveTowards(this.transform.position, wayPoints[curWayPoint].position, Time.deltaTime * speed);
        if(Vector3.Distance(transform.position, wayPoints[curWayPoint].position) < 0.5f){
           curWayPoint++;
           if(curWayPoint == wayPoints.Length){
               
           }
        }        
        }
    }
}
