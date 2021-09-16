using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMinion : Enemy 
{
    void Start()
    {
        setLife(10);
        setSpeed(0.01f);
        rigidbody_enemy = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        deathLogic();
        walk();
    }

    public void walk(){
        float velocity = -getSpeed();
        //rigidbody_enemy.velocity = new Vector2( Mathf.Sin(transform.position.y), velocity);
        transform.position = new Vector2(Mathf.Sin(transform.position.y),transform.position.y + velocity);
        Debug.Log("Deltatime: " + Time.deltaTime);
        Debug.Log("time: " + Time.time);
        Debug.Log("Time Framecount: " + Time.frameCount);
        Debug.Log("----------------------------");
        
    }


}
