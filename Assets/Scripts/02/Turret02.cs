using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret02 : MonoBehaviour
{
    [SerializeField] Transform m_Body = null;
    [SerializeField] GameObject m_PreBullet = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] Transform m_Target = null;

    public bool isStart = false;

    float time = 0f;

    private void Update()
    {
        m_Body.LookAt(m_Target);

        if (!isStart)
            return;

        time += Time.deltaTime;
        if(time >= 1f)
        {
            Shoot();
            time = 0f;
        }
    }

    void Shoot()
    {
        CreateBullet();
    }

    void CreateBullet()
    {
        GameObject go = Instantiate(m_PreBullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;

        Bullet02 bullet = go.GetComponent<Bullet02>();
        bullet.Init(m_Target);
    }

    private void OnDestroy()
    {
        for (int i = 0; i < m_BulletParent.childCount; i++)
        {
            Destroy(m_BulletParent.GetChild(i).gameObject);
        }
    }
}
