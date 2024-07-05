using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private Paddle playerPaddle;
    [SerializeField] private Paddle computerPaddle;
    [SerializeField] private Text playerScoreText;
    [SerializeField] private Text computerScoreText;

    private int playerScore;
    private int computerScore;

    public int PlayerScore
    {
        get { return playerScore; }
        private set
        {
            playerScore = value;
            playerScoreText.text = playerScore.ToString();
        }
    }

    public int ComputerScore
    {
        get { return computerScore; }
        private set
        {
            computerScore = value;
            computerScoreText.text = computerScore.ToString();
        }
    }

    private void Start()
    {
        ResetGame();
    }

    public void ScoreForPlayer()
    {
        PlayerScore++;
        ResetPositions();
        Debug.Log("Player Score!!!");
    }

    public void ScoreForComputer()
    {
        ComputerScore++;
        ResetPositions();
        Debug.Log("Computer Score!!!");
    }

    private void ResetPositions()
    {
        ball.ResetPosition();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }

    private void ResetGame()
    {
        PlayerScore = 0;
        ComputerScore = 0;
        ResetPositions();
    }
}
