using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Btn : MonoBehaviour
{
    int sceneid;
    [SerializeField] Button btn;
    public enum Buttontype
    {
        Home,
        Replay,
        Forward,
        Backward
    }
    public Buttontype buttontype;
    private void Awake()
    {
        switch(buttontype)
        {
            case Buttontype.Home:
                btn.onClick.AddListener(HomeFunct);
                break;
            case Buttontype.Replay:
                btn.onClick.AddListener(ReplayFunct);                
                break;
            case Buttontype.Forward:
                btn.onClick.AddListener(ForwardFunct);                
                break;
            case Buttontype.Backward:
                btn.onClick.AddListener(BackwardFunct);                
                break;
        }
        sceneid = SceneManager.GetActiveScene().buildIndex;

    }

    void HomeFunct()
    {
        SceneManager.LoadScene(1);
    }

    void ReplayFunct()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void ForwardFunct()
    {
        SceneManager.LoadScene(sceneid + 1);
    }

    void BackwardFunct()
    {
        SceneManager.LoadScene(sceneid - 1);
    }
}
