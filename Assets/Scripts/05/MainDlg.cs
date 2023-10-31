using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDlg : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] ReadyDlg m_Ready = null;
    
    void Start()
    {
        Init();
    }

    void Init()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
    }

    void OnClicked_Start()
    {
        m_Ready.Init();
        gameObject.SetActive(false);
    }

}
