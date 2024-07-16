using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    [SerializeField]
    private Paddle _playerPaddle;

    [SerializeField]
    private Paddle _computerPaddle;

    [SerializeField]
    private Ball _ball;

    [SerializeField]
    private Text _playerScoreText;

    [SerializeField]
    private Text _computerScoreText;

    public void PlayerScores()
    {
        _playerScore++;
        _playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        _computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        _playerPaddle.ResetPosition();
        _computerPaddle.ResetPosition();
        _ball.ResetPosition();
        _ball.AddStartingForce();
    }

}
