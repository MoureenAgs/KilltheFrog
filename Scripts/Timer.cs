using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 30f;
    public Text timerText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.Round(timeLeft);

        if (timeLeft <= 0)
        {
            Time.timeScale = 0;
        }
    }
}
