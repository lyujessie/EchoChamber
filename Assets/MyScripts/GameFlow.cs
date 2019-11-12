using UnityEngine;
using System.Collections;
using TMPro;

public class GameFlow : MonoBehaviour
{
    public float timeLeft = 60.0f; //set each level to be 30 seconds
    private TMP_Text Timer;

    // Use this for initialization
    void Start()
    {
        Timer = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        Timer.text = timeLeft.ToString("0");
    }
}
