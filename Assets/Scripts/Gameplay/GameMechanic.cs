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

    private Vector2 DirectionP = Vector2.zero;
    private Vector2 DirectionC = Vector2.zero;
        private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);

    }

    private void OnSwipe(string swipe)
    {
        if (DirectionP == Vector2.zero || DirectionC == Vector2.zero)
        {
            switch (swipe)
            {
                case "Left":
                    DirectionP = Vector2.left;
                    DirectionC = Vector2.left;
                    break;
                case "Right":
                    DirectionP = Vector2.right;
                    DirectionC = Vector2.right;

                    break;
                case "Up":
                    DirectionP = Vector2.up;
                    DirectionC = Vector2.up;

                    break;
                case "Down":
                    DirectionP = Vector2.down;
                    DirectionC = Vector2.down;

                    break;
            }
        }
        
        Debug.Log (swipe);
    }
    public void FixedUpdate()
    {
        P.position += (Vector3)DirectionP * Speed * Time.deltaTime;
        C.position += (Vector3)DirectionC * Speed * Time.deltaTime;

    }

    private void OnDisable()
    {
        swipeListener.OnSwipe.RemoveListener(OnSwipe);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P")
        {
            DirectionP = Vector2.zero;

        }
        if (collision.gameObject.tag == "C")
        {
            DirectionC = Vector2.zero;

        }
    }

    //How to lose/win*/
}
