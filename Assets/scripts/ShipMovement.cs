using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;
    private Transform t;
    private float moveInput;
    private Rigidbody rb;
    public GameObject targetAnim;
    public static Animator spaceAnim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        spaceAnim=targetAnim.GetComponent<Animator>();
    }

    public void MoveLeft() 
    {
        rb.velocity = Vector3.left * speed;
        spaceAnim.SetBool("moveLeft", true);
    }
    public void MoveRight() 
    {
        rb.velocity = Vector3.right * speed;
        spaceAnim.SetBool("moveRight", true);
    }

    public void poniterUP() 
    {
        rb.velocity = new Vector3(0,0,0);

        spaceAnim.SetBool("moveLeft", false);
        spaceAnim.SetBool("moveRight", false);
    }
    void Update()
    {
        //moveInput = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector3(moveInput*speed,rb.velocity.y,rb.velocity.z) ;

        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            spaceAnim.SetBool("moveLeft", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            spaceAnim.SetBool("moveRight", true);
        }
        else 
        {
            spaceAnim.SetBool("moveLeft", false);
            spaceAnim.SetBool("moveRight", false);
        }
        */

    }
   private void OnCollisionEnter(Collision collision)
   {
       //if (collision.gameObject.tag.Equals("sidewalls")) 
       //{
       //      spaceAnim.SetTrigger("hasTakenHit");
       //}
       if(collision.gameObject.tag.Equals("meteor"))
       {
            GameController.Lives--;
        }
    }
}
