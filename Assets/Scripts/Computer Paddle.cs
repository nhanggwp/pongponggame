

using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball; // Tham chiếu đến Rigidbody2D của bóng

    private void FixedUpdate()
    {
        bool isBallMovingTowardsPaddle = (ball.position.x < this.transform.position.x && ball.velocity.x > 0) ||
                                         (ball.position.x > this.transform.position.x && ball.velocity.x < 0);

        if (isBallMovingTowardsPaddle)
        {
            if (ball.position.y > this.transform.position.y) {
                _rigidbody.AddForce(Vector2.up * speed); // Di chuyển thanh trượt lên trên
            } else if (ball.position.y < this.transform.position.y) {
                _rigidbody.AddForce(Vector2.down * speed); // Di chuyển thanh trượt xuống dưới
            }
        }
        else
        {
            // Di chuyển về vị trí trung tâm và dừng lại ở đó cho đến khi bóng bắt đầu di chuyển về phía thanh trượt
            if (this.transform.position.y > 0f) {
                _rigidbody.AddForce(Vector2.down * speed); // Di chuyển thanh trượt xuống dưới
            } else if (this.transform.position.y < 0f) {
                _rigidbody.AddForce(Vector2.up * speed); // Di chuyển thanh trượt lên trên
            }
        }
    }
}
