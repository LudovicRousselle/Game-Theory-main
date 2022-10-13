using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unrailed_TrainFloowForward : MonoBehaviour
{

    private Unrailed_CubeForward cubeScript;


    // Start is called before the first frame update
    void Start()
    {
        cubeScript.GetComponent<Unrailed_CubeForward>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, cubeScript.cubeSpeed) * Time.deltaTime;
    }
}
