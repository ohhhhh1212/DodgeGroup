using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet02 : MonoBehaviour
{
    [SerializeField] float m_Speed = 5f;
    Transform m_Target = null;

    public void Init(Transform target)
    {
        m_Target = target;

        transform.LookAt(m_Target);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
    }
}
