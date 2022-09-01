using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoridMove : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector2 screenBounds;
    private Vector3 v3;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (GameController.score > 260)
        {
            speed = 60;
        }
        else if(GameController.score >500)
        {
            speed = 100;
        }
        else if (GameController.score > 900)
        {
            speed = 150;
        }
        rb.velocity = Vector3.back * speed;
        if (transform.position.z < 2.32)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag.Equals("ship")) 
        {
            AudioManager.PlaySound("hit");
            ShipMovement.spaceAnim.SetTrigger("hasTakenHit");
        }
    }
}
