using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Button Home, Replay;
    [SerializeField] TextMeshProUGUI timer;
    public float remainingtime;
    [SerializeField] GameObject LevelFail, LevelWin;
    bool Solved;
   
    private void Awake()
    {
        Home.onClick.AddListener(Main);
        Replay.onClick.AddListener(Reset);
    }


    
    void Update()
    {

        if (remainingtime >0)
        {
            remainingtime -= Time.deltaTime;
            timer.text = string.Format("00:{0:00}", remainingtime);
        }
        else if (remainingtime <0)
        {
            remainingtime = 0;
        }

        if (remainingtime == 0 && Solved ==true)
        {
            LevelWin.SetActive(true);
        }

        else if (remainingtime == 0 && Solved ==false)
        {
            LevelFail.SetActive(false);
        }
    }
    public void Reset()
    {
        Debug.Log("Reset");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Main()
    {
        SceneManager.LoadScene(1);
    }    
}
