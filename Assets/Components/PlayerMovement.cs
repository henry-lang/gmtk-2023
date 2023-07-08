using System;
using System.Linq;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float movementSpeed = 100f;
    private Rigidbody2D _rb;
    private BoxCollider2D _collider;
        
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(movementSpeed * Time.deltaTime, _rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var normal = collision.GetContact(0).normal;
        if (new[]{Vector2.left, Vector2.right}.Contains(normal) && collision.gameObject.CompareTag("Ground"))
        {
            var velocity = _rb.velocity;
            velocity = new Vector2(-velocity.x, velocity.y);
            _rb.velocity = velocity;
        }
    }
}