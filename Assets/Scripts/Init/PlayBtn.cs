using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayBtn : MonoBehaviour
{
    [SerializeField] Button Play;
    public int sceneid;
    public void Start()
    {
        Play.onClick.AddListener(OpenMain);
    }

    void OpenMain()
    {
        SceneManager.LoadScene(sceneid);
    }
}
