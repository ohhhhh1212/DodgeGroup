using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Msgbox : MonoBehaviour
{
    [SerializeField] Button m_btnOk = null;
    [SerializeField] Button m_btnCancel = null;
    [SerializeField] GameObject m_imgBG = null;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        m_btnOk.onClick.AddListener(OnClicked_Ok);
        m_btnCancel.onClick.AddListener(OnClicked_Cancel);
    }

    void OnClicked_Ok()
    {
        SceneManager.LoadScene(0);
    }

    void OnClicked_Cancel()
    {
        m_imgBG.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            m_imgBG.SetActive(true);
        }
    }
}
