using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player03 : MonoBehaviour
{
    [SerializeField] float m_Speed = 5.0f;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 pos = new Vector3(x, 0f, z) * m_Speed * Time.deltaTime;

        transform.Translate(pos, Space.World);
    }
}
