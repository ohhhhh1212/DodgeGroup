using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene07Dlg : MonoBehaviour
{
    [SerializeField] Text m_txtTime = null;
    [SerializeField] Button m_btnStart = null;
    [SerializeField] Button m_btnStop = null;
    [SerializeField] Button m_btnClear = null;

    float time = 0f;
    bool m_IsStart = false;

    int min = 0;
    float sec = 0;
    float ms = 0;

    void Update()
    {
        if (!m_IsStart)
            return;

        time += Time.deltaTime;

        ms = time * 100;
   
        if(ms >= 100)
        {
            if(sec + 1 >= 60)
            {
                sec = 0;
                min += 1;
            }
            else
                sec += 1;

            ms = 0f;
            time = 0f;
        }
        
        m_txtTime.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, ms);
    }

    private void Start()
    {
        Init();
    }

    void Init()
    {
        m_btnStart.onClick.AddListener(OnClicked_Start);
        m_btnStop.onClick.AddListener(OnClicked_Stop);
        m_btnClear.onClick.AddListener(OnClicked_Clear);
    }

    void OnClicked_Start()
    {
        m_IsStart = true;
    }

    void OnClicked_Stop()
    {
        m_IsStart = false;
    }

    void OnClicked_Clear()
    {
        time = 0f;
        m_IsStart = false;
        min = 0;
        sec = 0;
        ms = 0;
        m_txtTime.text = "00:00:00";
    }

}
