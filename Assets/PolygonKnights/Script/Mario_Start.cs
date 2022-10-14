using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Mario_Start : MonoBehaviour
{

    [SerializeField] Transform parent;
    [SerializeField] GameObject child;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("wololo");
        child.transform.SetParent(parent);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("squalala");
        child.transform.SetParent(null);
    }
}
