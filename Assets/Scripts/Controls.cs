using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    [SerializeField]
    int speed;

    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.rotation.eulerAngles.y < rightLimit)
            {
                transform.Rotate(new Vector3(0, 1, 0) * (speed * Time.deltaTime));
            }

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.rotation.eulerAngles.y > leftLimit)
            {
                transform.Rotate(new Vector3(0, 1, 0) * (-speed * Time.deltaTime));
            }
        }
    }
}//bless your socks!!!
