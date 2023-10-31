using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet04 : MonoBehaviour
{
    [SerializeField] float m_Speed = 7.0f;
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

    private void Start()
    {
        Destroy(gameObject, 5f);
    }
}
