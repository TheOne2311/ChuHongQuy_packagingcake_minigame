using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    public float remainingtime;
    public GameObject LevelFail, LevelWin;
    public GameObject P, C, Cd;
    private GameObject[] objects;
    
    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("Cd");
        if (remainingtime >0)
        {
            remainingtime -= Time.deltaTime;
            timer.text = string.Format("00:{0:00}", remainingtime);
        }
        else if (remainingtime <0)
        {
            remainingtime = 0;
        }
        if (remainingtime == 0)
        {
            Destroy(P);
            Destroy(C);
            for (int i = 0; i < objects.Length; i++)
            {
                Object.Destroy (objects[i]);
            }
            LevelFail.SetActive(true);
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
