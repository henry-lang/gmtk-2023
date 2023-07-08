using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float movementSpeed = 10f;
    private Rigidbody2D _rb;
    private BoxCollider2D _collider;
    private bool _isGrounded;
        
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(_isGrounded);
        if (_isGrounded)
            _rb.velocity = movementSpeed * Time.deltaTime * Vector2.right;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
            _isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exited");
            _isGrounded = false;
    }
}
