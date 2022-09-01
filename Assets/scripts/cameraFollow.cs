using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public float followSpeed = 2f;
    public GameObject target;

    void Update()
    {

            transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z-5f);
    }
}
