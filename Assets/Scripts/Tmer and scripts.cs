using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float score;
    public float timer;
    public TMP_Text scoreText;
    public TMP_Text timertext;
    public float timers = 1f;
    public float timeMultiplier = 1f;
    public float scoreMultiplier = 5f;


    void Update()
    {
        timers += Time.deltaTime;
        score = timers * scoreMultiplier;
        timer = timers * timeMultiplier;
        scoreText.text = "Score: " + Mathf.Round(score).ToString();
        timertext.text = "Time: " + Mathf.Round(timer).ToString();
    }
}