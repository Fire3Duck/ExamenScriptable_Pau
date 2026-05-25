using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float movementSpeed = 5;

    void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody2D.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rigidBody2D.linearVelocity.y);
    }
}
