using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    [SerializeField] GameObject Win, P, C;
    private GameObject[] objects;

    private void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("Cd");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="P")
        {
            Win.SetActive(true);
            Destroy(P);
            Destroy(C);
            for (int i=0; i<objects.Length; i++)
            {
                Object.Destroy (objects[i]);
            }

        }
    }

}
