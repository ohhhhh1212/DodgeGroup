using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02 : MonoBehaviour
{
    [SerializeField] float m_Speed = 5.0f;
    [SerializeField] FXParticle m_ptcBomb = null;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            Destroy(collision.collider.gameObject);
            m_ptcBomb.Play();
        }
    }

}
