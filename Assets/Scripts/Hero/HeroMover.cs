using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HeroMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, _rigidbody2D.velocity.y);

        if (Input.GetButton("Jump"))
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
        }
    }
}
