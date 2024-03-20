using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GG.Infrastructure.Utils.Swipe;

public class GameMechanic : MonoBehaviour
{
    [SerializeField] private SwipeListener swipeListener;
    [SerializeField] float Speed;
    [SerializeField] Transform P,C;
    [SerializeField] Rigidbody2D Present, Cake;


    private void Start()
    {
        Present = GetComponent<Rigidbody2D>();
        Cake = GetComponent<Rigidbody2D>();

    }

    private Vector2 Direction = Vector2.zero;
        private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);

    }

    private void OnSwipe(string swipe)
    {
        if (Direction == Vector2.zero)
        {
            switch (swipe)
            {
                case "Left":
                    Direction = Vector2.left;
                    break;
                case "Right":
                    Direction = Vector2.right;
                    break;
                case "Up":
                    Direction = Vector2.up;
                    break;
                case "Down":
                    Direction = Vector2.down;
                    break;
            }
        }
        
        Debug.Log (swipe);
    }
    public void FixedUpdate()
    {
        P.position += (Vector3)Direction * Speed * Time.deltaTime;
        C.position += (Vector3)Direction * Speed * Time.deltaTime;

    }

    private void OnDisable()
    {
        swipeListener.OnSwipe.RemoveListener(OnSwipe);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "C" || collision.gameObject.tag == "P")
        {
            Debug.Log("Collision!!");
        }
        Direction = Vector2.zero;
    }
}
