using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0,speed);
        if(transform.position.y > 30){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" a");
    }
    void OnCollisionStay(Collision collision)
    {
            //Output the message
            Debug.Log(" b");
        
    }

}
