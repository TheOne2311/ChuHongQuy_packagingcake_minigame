using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HTP : MonoBehaviour
{
    public Button close;
    public GameObject HTPPanel, ChooseLevel, back;
     void Start()
    {
        close.onClick.AddListener(Manage);
    }

    void Manage()
    {
        HTPPanel.SetActive(false);
        ChooseLevel.SetActive(true);
        back.SetActive(true);
        close.gameObject.SetActive(false);
    }


}
