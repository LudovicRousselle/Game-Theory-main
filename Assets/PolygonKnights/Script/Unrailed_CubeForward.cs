using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unrailed_CubeForward : MonoBehaviour
{


    public float cubeSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, cubeSpeed) * Time.deltaTime;
    }
}
