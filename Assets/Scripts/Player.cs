using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public int movementSpeed = 5;

    void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rigidBody2D.linearVelocity = new Vector2(Item.GetAxis("Horizontal") * movementSpeed.rigidBody2D.linearVelocity.y);
    }
}
