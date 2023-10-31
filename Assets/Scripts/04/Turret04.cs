using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret04 : MonoBehaviour
{
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] Transform m_BulletParent = null;
    [SerializeField] Transform m_Body = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] GameObject m_preBullet = null;

    bool m_IsStart = false;

    public void StartShoot()
    {
        m_IsStart = true;
        StartCoroutine(Co_StartShoot());
    }

    public void StopShoot()
    {
        m_IsStart = false;
    }

    IEnumerator Co_StartShoot()
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
        GameObject go = Instantiate(m_preBullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;

        Bullet04 bullet = go.GetComponent<Bullet04>();
        bullet.Init(m_Target);
    }

    private void Update()
    {
        m_Body.LookAt(m_Target);
    }
}
