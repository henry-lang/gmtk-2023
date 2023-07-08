using System;
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

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(movementSpeed * Time.deltaTime, _rb.velocity.y);
    }
}