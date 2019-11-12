using UnityEngine;
using System.Collections;
using TMPro;

public class GameFlow : MonoBehaviour
{
    public float timeLeft = 60.0f; //set each level to be 60 seconds
    public TMP_Text timer;
    public int currentLevel;
    public Light lightFirst;
    public Light lightSecond;
    public Light lightThird;

    // For lighting color
    public float r = 1;
    public float g = 1;
    public float b = 1;

    // Use this for initialization
    void Start()
    {
        timer = GetComponent<TMP_Text>();
        currentLevel = 1;

        // set up lighting
        lightFirst.color = new Color(r, g, b);
        lightSecond.color = new Color(r, g, b);
        lightThird.color = new Color(r, g, b);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.text = timeLeft.ToString("0");

        if (timeLeft <= 0)
        {
            currentLevel++;
            timeLeft = 60.0f;

            if (currentLevel == 2) {
                // tODO: dynamically load messages to TextPro

                // Change lighting
                g = 0.75f;
                b = 0.75f;
                lightFirst.color = new Color(r, g, b);
                lightSecond.color = new Color(r, g, b);
                lightThird.color = new Color(r, g, b);
            }
            else if (currentLevel == 3) {
                // tODO: dynamically load messages to TextPro

                // Change lighting
                g = 0.5f;
                b = 0.5f;
                lightFirst.color = new Color(r, g, b);
                lightSecond.color = new Color(r, g, b);
                lightThird.color = new Color(r, g, b);
            }
            else if (currentLevel > 3) {

            }
        }
    }
}
