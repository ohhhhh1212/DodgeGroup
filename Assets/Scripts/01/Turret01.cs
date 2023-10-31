using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret01 : MonoBehaviour
{
    [SerializeField] Transform m_Body = null;
    [SerializeField] Transform m_BulletPos = null;
    [SerializeField] GameObject m_PrefabBullet = null;
    [SerializeField] Transform m_Target = null;
    [SerializeField] Transform m_BulletParent = null;

    void Start()
    {
        Init();
    }

    public void Init()
    {

    }

    void Fire()
    {
        CreateBullet();
    }

    void CreateBullet()
    {
        GameObject go = Instantiate(m_PrefabBullet, m_BulletParent);
        go.transform.position = m_BulletPos.position;
        Bullet01 bullet = go.GetComponent<Bullet01>();

        bullet.Init(m_Target);

        Destroy(bullet, 8f);
    }

    void Update()
    {
        m_Body.LookAt(m_Target);

        if (Input.GetMouseButtonDown(0))
            Fire();
    }

    void DestroyBullet()
    {
        for (int i = 0; i < m_BulletParent.childCount; i++)
        {
            Destroy(m_BulletParent.GetChild(i).gameObject);
        }
    }

    private void OnDestroy()
    {
        DestroyBullet();
    }
}
