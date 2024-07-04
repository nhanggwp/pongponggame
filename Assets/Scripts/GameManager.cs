using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
     public Paddle playerpaddle;
          public Paddle ComputerPaddle;
          

    public Text textforPlayer;
    public Text textforComputer;
    private int PlayerScore;
    private int ComputerScore;
    public void ScoreforPlayer(){
        PlayerScore++;
        this.textforPlayer.text=PlayerScore.ToString();

        ball.ResetPosition();
        this.playerpaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
        Debug.Log("PlayerSocre!!!!!");
        
    }
    public void ScoreforComputer(){
        ComputerScore++;
        this.textforComputer.text=ComputerScore.ToString();

         ball.ResetPosition();
        this.playerpaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
          Debug.Log("ComputerScore!!!!!");
    }
  
    // Start is called before the first frame update
}
