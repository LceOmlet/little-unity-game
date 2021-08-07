using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    private ScoreData scoreData;
    // Start is called before the first frame update
    void Start()
    {
        scoreData = GameObject.Find("Score").GetComponent<ScoreData>();
    }

    // Update is called once per frame
    void Update()
    {
        Text text = GetComponent<Text>();
        text.text = "" + scoreData.getScore();
    }
}
