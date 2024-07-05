
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip Pongpeep;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _audioSource.PlayOneShot(Pongpeep);
    }
    public float speed = 200f;
    // Start is called before the first frame update
    private Rigidbody2D _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();

    }
    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.Range(-1.0f, 1.0f);
        if (y >= -0.5f && y <= 0.5f)
        {
            y = y < 0 ? -0.5f : 0.5f;
        }
        Vector2 direction = new Vector2(x, y).normalized;
        _rigidbody.AddForce(direction * speed);

    }
    //Encapsulation application 
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        AddStartingForce();
    }
}

