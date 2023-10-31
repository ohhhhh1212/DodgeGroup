using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet01 : MonoBehaviour
{
    public float m_Speed = 10f;
    Transform m_Target = null;

    void Update()
    {
        Move();
    }

    public void Init(Transform target)
    {
        m_Target = target;
        transform.LookAt(m_Target);
    }

    void Move()
    {
        transform.position += transform.forward * Time.deltaTime * m_Speed;
    }
}
