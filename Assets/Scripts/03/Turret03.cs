using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret03 : MonoBehaviour
{
    [SerializeField] Transform m_Body = null;
    [SerializeField] GameObject m_PreBullet = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] Transform m_Target = null;

    public bool m_IsStart = false;

    private void Update()
    {
        m_Body.LookAt(m_Target);
    }

    public void StartShoot()
    {
        m_IsStart = true;
        StartCoroutine(CO_StartShoot());
    }

    public void StopShoot()
    {
        m_IsStart = false;
    }

    IEnumerator CO_StartShoot()
    {
        while (m_IsStart)
        {
            yield return new WaitForSeconds(1f);
            Shoot();
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

        Bullet03 bullet = go.GetComponent<Bullet03>();
        bullet.Init(m_Target);

        Destroy(bullet, 5f);
    }

    private void OnDestroy()
    {
        for (int i = 0; i < m_BulletParent.childCount; i++)
        {
            Destroy(m_BulletParent.GetChild(i).gameObject);
        }
    }
}
