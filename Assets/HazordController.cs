using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazordController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong (Time.time * speed, 15), transform.position.z);
    }
}
