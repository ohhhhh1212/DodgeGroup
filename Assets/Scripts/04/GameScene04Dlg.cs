using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene04Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Turret04[] m_Turrets = null;

    bool m_IsStart = false;

    void Start()
    {
        Init();
    }

    void Init()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
    }

    void OnClicked_Start()
    {
        if (m_IsStart)
            return;

        for (int i = 0; i < m_Turrets.Length; i++)
        {
            m_Turrets[i].StartShoot();
        }

        m_IsStart = true;
    }

    void OnClicked_Stop()
    {
        if (!m_IsStart)
            return;

        for (int i = 0; i < m_Turrets.Length; i++)
        {
            m_Turrets[i].StopShoot();
        }

        m_IsStart = false;
    }
}
