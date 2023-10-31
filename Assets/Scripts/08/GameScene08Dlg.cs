using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScene08Dlg : MonoBehaviour
{
    [SerializeField] Button[] m_btnScenes = null;

    private void Start()
    {
        Init();
    }

    void Init()
    {
        for (int i = 0; i < m_btnScenes.Length; i++)
        {
            int idx = i + 1;
            m_btnScenes[i].onClick.AddListener(() => OnClicked_Scene(idx));
        }
    }

    void OnClicked_Scene(int idx)
    {
        SceneManager.LoadScene(idx);
    }
}
