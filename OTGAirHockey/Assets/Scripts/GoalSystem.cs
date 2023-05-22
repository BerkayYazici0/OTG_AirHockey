using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalSystem : MonoBehaviour
{
    public Text blueScoreText;
    public Text redScoreText;
    public Text timerText;
    private int blueScore;
    private int redScore;
    public float timer;

    private void Update()
    {
        timer -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        if(timer <= 0)
        {
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BlueGoal"))
        {
            redScore++;
            redScoreText.text = redScore.ToString();

            transform.position = new Vector3(0f,0f,0f);
            transform.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(4f, 0);
        }
        if (collision.gameObject.CompareTag("RedGoal"))
        {
            blueScore++;
            blueScoreText.text = blueScore.ToString();

            transform.position = new Vector3(0f, 0f, 0f);
            transform.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-4f, 0);
        }
    }
}
