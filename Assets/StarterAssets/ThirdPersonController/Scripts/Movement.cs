using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour {


    public float x;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    void FixedUpdate()
    {
        x = Input.GetAxis("Mouse X");
        transform.Rotate(0f, x, 0f);
    }
}
