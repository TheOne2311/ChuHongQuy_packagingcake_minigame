using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayBtn : MonoBehaviour
{
    [SerializeField] Button Play;
    public void Start()
    {
        Play.onClick.AddListener(OpenMain);
    }

    //To open the Main 
    public void OpenMain()
    {
        SceneManager.LoadScene(1);
    }
}
