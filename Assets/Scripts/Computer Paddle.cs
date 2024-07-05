

using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField]
    private Rigidbody2D ball; 

    private void FixedUpdate()
    {
        bool isBallMovingTowardsPaddle = (ball.position.x < this.transform.position.x && ball.velocity.x > 0) ||
                                         (ball.position.x > this.transform.position.x && ball.velocity.x < 0);

        if (isBallMovingTowardsPaddle)
        {
            if (ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed); //Add force to move the paddle go up 
            }
            else if (ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed); // Add force to move the paddle go up 
            }
        }
        else
        {
            // Move the paddle back to its original position (center) when the ball is not approaching
            if (this.transform.position.y > 0f)
            {
                _rigidbody.AddForce(Vector2.down * speed); // Add force to move the paddle go down 
            }
            else if (this.transform.position.y < 0f)
            {
                _rigidbody.AddForce(Vector2.up * speed); // Add force to move the paddle go up 
            }
        }
    }
}
