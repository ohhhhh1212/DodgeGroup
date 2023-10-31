using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene02Dlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Turret02 m_turret = null;

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
        m_turret.isStart = true;
    }

    void OnClicked_Stop()
    {
        m_turret.isStart = false;
    }
}
