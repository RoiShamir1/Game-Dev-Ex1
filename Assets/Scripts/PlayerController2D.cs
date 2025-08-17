using Unity.VisualScripting;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Transform respawnPoint;

    private Rigidbody2D rb;
    float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null) Debug.LogError("Rigidbody2D is null!");
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocity.y);
    }

    public void Respawn()
    {
        rb.position = respawnPoint.position;
        rb.linearVelocity = Vector2.zero;
    }

}
