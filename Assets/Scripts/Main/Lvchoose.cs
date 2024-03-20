using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lvchoose : MonoBehaviour
{
    [SerializeField] Button lv1, lv2, lv3;
    public int LevelChoose;
    void OnEnable()
    {
        lv1.onClick.AddListener(LS1);
        lv2.onClick.AddListener(LS2);
        lv3.onClick.AddListener(LS3);
    }

    void LS1()
    {
        SceneManager.LoadScene(3);
        Debug.Log("Lv1Loaded");
    }
    void LS2()
    {
        SceneManager.LoadScene(4);
        Debug.Log("Lv2Loaded");
    }
    void LS3()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Lv3Loaded");
    }
}
