using UnityEngine;

public class JumpPadController : MonoBehaviour
{
    [SerializeField] public float boostForce = 1000;
    
    private BoxCollider2D _collider;

    public void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var rb = other.gameObject.GetComponent<Rigidbody2D>();
            //rb.velocity = new Vector2(rb.velocity.x, boostForce);
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(transform.up * boostForce);
        }
    }
}
