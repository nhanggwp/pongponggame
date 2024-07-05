
using UnityEngine;

public class BoundarySurface : MonoBehaviour
{
    public float bounceforce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            Vector2 normalvector = collision.GetContact(0).normal;
            collision.gameObject.GetComponent<Ball>().AddForce(-normalvector * this.bounceforce);
        }
    }
}
