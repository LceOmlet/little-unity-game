using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : MonoBehaviour
{
    private float score = 0f;

    private void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
    }

    public float getScore()
    {
        return score;
    }

    public void setScore(float score)
    {
        this.score = score;
    }
}
