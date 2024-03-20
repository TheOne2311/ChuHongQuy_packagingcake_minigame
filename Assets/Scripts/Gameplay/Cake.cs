using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    [SerializeField] GameObject Win, P;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="P")
        {
            Win.SetActive(true);
            Destroy(P);
        }
    }

}
