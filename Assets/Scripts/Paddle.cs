
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField]
    protected float speed = 10f;
    protected Rigidbody2D _rigidbody;


    private void Awake()
    {
        // Search for the Rigidbody2D component on the same GameObject.
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    public void ResetPosition()
    {
        //Reset the ball to its original position.
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0);
        _rigidbody.velocity = Vector3.zero;
    }

}