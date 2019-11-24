using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{

    public Text NameText;
    public Text SpeedText;
    public Text ScoreText;
    public Text HighScoreText;

    private void Awake()
    {
        NameText.text = keepData.PlayerName;
        ScoreText.text = keepData.PlayerScore.ToString();
        HighScoreText.text = keepData.HighScore.ToString();
    }




}
