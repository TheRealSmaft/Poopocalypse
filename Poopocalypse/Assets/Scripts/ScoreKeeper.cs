using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public Text scoreUI;
    public int poopScoopPointValue;
    public int poopSquishPointDetriment;

    private int _score = 0;
    public int score
    {
        get
        {
            return _score;
        }
    }

    public void AddValue()
    {
        _score += poopScoopPointValue;
        UpdateScore();
    }

    public void RemoveValue()
    {
        _score -= poopSquishPointDetriment;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreUI.text = "Score: " + _score;
    }
}
