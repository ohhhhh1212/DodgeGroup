using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainDlg02 : MonoBehaviour
{
    [SerializeField] Button m_btnStart = null;
    [SerializeField] ReadyDlg02 m_ReadyDlg = null;

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
        m_ReadyDlg.Init();
        gameObject.SetActive(false);
    }

}
