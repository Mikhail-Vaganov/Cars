using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public float CriticalSpeed = 0.05f;
    public float MaxIdleTime = 3;

    private float timer = 0;
    private Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {
        var currentPosition = transform.GetChild(0).position;
        var velocity = (currentPosition.x-lastPosition.x)/Time.deltaTime;
        if(velocity>CriticalSpeed)
            timer = 0;
        else
            timer +=Time.deltaTime;

        Debug.Log(velocity);

        lastPosition = currentPosition;

        if (timer > MaxIdleTime)
            Destroy(gameObject);
    }
}
