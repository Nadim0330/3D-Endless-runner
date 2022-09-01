using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGloop : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 startPostion;

    void Start()
    {
        startPostion = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.back*speed*Time.deltaTime);
        if (transform.position.z < -26.76634) 
        {
            transform.position = startPostion;
        }
    }
}
