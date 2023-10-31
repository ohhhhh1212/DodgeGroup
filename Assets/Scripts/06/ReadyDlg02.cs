using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyDlg02 : MonoBehaviour
{
    [SerializeField] Text m_txtCount = null;

    bool m_IsStart = false;
    float time = 0f;
    int count = 3;
    float scaleTime = 0f;
    Vector3 m_Size = Vector3.zero;


    public void Init()
    {
        gameObject.SetActive(true);
        m_Size = m_txtCount.transform.localScale;
        m_IsStart = true;
    }

    void Update()
    {
        if (!m_IsStart)
            return;

        time += Time.deltaTime;

        if (time > 1f)
        {
            if(count > 0)
            {
                m_txtCount.text = count.ToString();
                count -= 1;
            }
            else
            {
                m_txtCount.text = "Start!!";
            }

            time = 0f;
        }

        TextSize();

        if (count <= 0)
        {
            gameObject.SetActive(false);
            m_IsStart = false;
        }
    }

    float delay = 0.6f;

    void TextSize()
    {
        m_txtCount.transform.localScale = m_Size;

        scaleTime += Time.deltaTime;

        if(scaleTime <= 1f)
        {
            if(scaleTime <= delay)
            {
                Vector3 size = Vector3.Lerp(m_Size, m_Size / 2, scaleTime / delay);
                m_txtCount.transform.localScale = size;
            }
        }
        else
        {
            scaleTime = 0f;
        }
    }
}
