 using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public Paddle playerPaddle;
    public int playerScore  {get; private set; }
    public Text playerScoreText;

    public Paddle computerPaddle;
    public int computerScore  { get; private set; }
    public Text computerScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        //ball.AddStartingForce();
        Debug.Log("GameManager->StartRound()"); 
    }

    public void PlayerScores()
    {
        SetPlayerScore(playerScore + 1);
        Debug.Log("GameManager->PlayerScores()");
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        Debug.Log("GameManager->ComputerScores()");
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = playerScore.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = computerScore.ToString();
    }


}
