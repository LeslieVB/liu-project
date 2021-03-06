﻿using UnityEngine;
using System.Collections;

public class scoreLPManager : MonoBehaviour
{
    private float lifePoints;
    private int score;
    private int highScore;
    // Use this for initialization
    void Start()
    {
        lifePoints = 100;
        score = 0;
        highScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        highScore = Mathf.Max(score, highScore);
    }

    public float LifePoints
    {
        get
        {
            return lifePoints;
        }

    }

    public int Score
    {
        get
        {
            return score;
        }
    }

    public void increaseScore(int amount)
    {
            score += amount;
    }
    public void decreaseLifePoint(float amount)
    {
        if (lifePoints - amount > 0f)
            lifePoints -= amount;
    }
    public void increaseLifePoints(float amount)
    {
        if (lifePoints + amount < 100f)
            lifePoints += amount;
        else
            lifePoints = 100f;
    }
}
