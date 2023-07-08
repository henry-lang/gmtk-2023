using System.Linq;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float movementSpeed = 100f;
    private Rigidbody2D _rb;
    public Vector2 _dir = Vector2.right;
    public float acceleration = 5;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = movementSpeed * Time.deltaTime * _dir + new Vector2(0, _rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var normal = collision.GetContact(0).normal;
        Debug.Log(normal);
        if (new[]{Vector2.left, Vector2.right}.Contains(normal) && collision.gameObject.CompareTag("Ground"))
        {
            _dir *= -1;
        }
    }
}