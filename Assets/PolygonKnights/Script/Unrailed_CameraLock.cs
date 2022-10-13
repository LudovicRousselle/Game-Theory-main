using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unrailed_CameraLock : MonoBehaviour
{
    [SerializeField] Unrailed_CubeForward cubeScript;
    [SerializeField] Camera mainCam;
    [SerializeField] GameObject trainFollow;
    [SerializeField] GameObject trainObject;
    [SerializeField] Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        cubeScript.GetComponent<Unrailed_CubeForward>();
        cubeScript.cubeSpeed = trainObject.GetComponent<Unrailed_CubeForward>().cubeSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (trainObject.transform.position.z - trainFollow.transform.position.z <= 0)
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
            cubeScript.enabled = false;

        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezePositionY;
            cubeScript.enabled = true;
        }
    }
}
