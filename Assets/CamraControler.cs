using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraControler : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;
         
    // Start is called before the first frame update
    void Start()
    {
        offset = Target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position - offset;
        transform.LookAt(Target);
    }
}
