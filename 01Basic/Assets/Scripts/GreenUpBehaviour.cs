using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenUpBehaviour : MonoBehaviour
{
    public float speed = 10f;
    public float mHeroRotateSpeed = 90f / 2f; // 90-degrees in 2 seconds
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos += ((speed * Time.smoothDeltaTime) * transform.up);
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos -= ((speed * Time.smoothDeltaTime) * transform.up);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.forward, -mHeroRotateSpeed * Time.smoothDeltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.forward, mHeroRotateSpeed * Time.smoothDeltaTime);
        }

        transform.position = pos;
    }
}
