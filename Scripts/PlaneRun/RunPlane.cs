using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunPlane : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float min;
    [SerializeField]
    private float max;
    private Rigidbody rb;

    [SerializeField]
    private RunPlane plane;

    private void Start() {
        gameObject.transform.position = new Vector3(0,0,min);
    }
    private void FixedUpdate() {
        gameObject.transform.position = new Vector3(0,0,Mathf.Clamp(gameObject.transform.position.z, min, max));
        gameObject.transform.Translate(Vector3.forward * speed);
        if(gameObject.transform.position.z >= max)
        {
            plane.enabled = false;
        }
    }

}
