using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyDlg : MonoBehaviour
{
    [SerializeField] Text m_txtCount = null;
    Vector3 m_Scale = Vector3.zero;

    public void Init()
    {
        gameObject.SetActive(true);
        m_Scale = m_txtCount.transform.localScale;
        StartCount();
    }

    void StartCount()
    {
        StartCoroutine(Co_Count());
    }

    IEnumerator Co_Count()
    {
        for (int i = 3; i > 0; i--)
        {
            m_txtCount.text = i.ToString();

            StartCoroutine(Co_TextSize2());
            yield return new WaitForSeconds(1f);
        }

        m_txtCount.text = "Start!!";

        StartCoroutine(Co_TextSize2());
        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);
    }

    IEnumerator Co_TextSize()
    {
        m_txtCount.fontSize = 140;

        for (int i = 0; i < 40; i++)
        {
            m_txtCount.fontSize -= 2;
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(0.6f);
    }

    IEnumerator Co_TextSize2()
    {
        m_txtCount.transform.localScale = m_Scale;

        for (int i = 1; i <= 10; i++)
        {
            Vector3 size = Vector3.Lerp(m_Scale, m_Scale / 2, (i / 10f));
            m_txtCount.transform.localScale = size;

            yield return new WaitForSeconds(0.05f);
        }
    }

}
