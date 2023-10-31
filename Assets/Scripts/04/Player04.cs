using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player04 : MonoBehaviour
{
    [SerializeField] float m_Speed = 7f;
    [SerializeField] FXParticle m_ptcBomb = null;

    void Move()
    {
        float z = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");

        Vector3 dir = new Vector3(x, 0f, z) * m_Speed * Time.deltaTime;

        transform.Translate(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Destroy(collision.collider.gameObject);
            m_ptcBomb.Play();
        }
    }

    void Update()
    {
        Move();
    }
}
