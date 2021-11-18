using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class HeroMover : MonoBehaviour
{
    public event UnityAction<float> HeroMoved;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private bool _onGround = true;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _onGround = true;
    }

    private void Update()
    {
        Move();

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (_onGround)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            _onGround = false;
        }
    }

    private void Move()
    {
        var dir = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(dir * _speed, _rigidbody2D.velocity.y);

        HeroMoved?.Invoke(dir);
    }
}
