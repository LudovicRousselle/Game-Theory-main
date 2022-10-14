using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mario_Start : MonoBehaviour
{

    [SerializeField] Transform parent;
    [SerializeField] GameObject child;
    [SerializeField] GameObject triggerZone;
    [SerializeField] float waitingTime;
    private bool isStarted = false;

    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (direction.y < 0 && isStarted == true)
        {
            Debug.Log("rikiki");
            child.transform.SetParent(null);
            triggerZone.transform.SetParent(null);
        }

        Invoke("TriggerFollow" , waitingTime);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("wololo");
        child.transform.SetParent(parent);
        isStarted = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("squalala");
        child.transform.SetParent(null);
        isStarted = false;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>();
    }

    void TriggerFollow()
    {
        if (direction.y > 0 && isStarted == true)
        {
            Debug.Log("Chalala");
            triggerZone.transform.SetParent(parent);
        }
    }
}
