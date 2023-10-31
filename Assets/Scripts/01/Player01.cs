using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : MonoBehaviour
{
    const float DEFAULT_SPEED = 10;
    [SerializeField] float m_speed = 1.0f;


    void Update()
    {
        float xDelta = Input.GetAxis("Horizontal");
        float zDelta = Input.GetAxis("Vertical");

        float x = xDelta * m_speed * Time.deltaTime * DEFAULT_SPEED;
        float z = zDelta * m_speed * Time.deltaTime * DEFAULT_SPEED;

        transform.Translate(x, 0, z, Space.World);
    }
}
