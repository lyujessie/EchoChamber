using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OpinionObject : MonoBehaviour, iGazeReceiver
{
    private bool isGazingUpon;
    public AudioSource opinion_audio;
    public int opinionSide;
    public GameObject timer;

    // Start is called before the first frame update
    void Start()
    {
        opinionSide = 0;
        timer = GameObject.Find("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        opinion_audio = GetComponent<AudioSource>();

        if (isGazingUpon)
        {
            if (!opinion_audio.isPlaying)
            {
                opinion_audio.Play(); // Playing the audio file associated with opinion_audio
            }

            // add score update
            if (opinionSide == 1)
            {
                timer.GetComponent<GameFlow>().blueScore++;
            } else if (opinionSide == -1)
            {
                timer.GetComponent<GameFlow>().redScore++;
            }
        }
    }

    public void GazingUpon()
    {
        isGazingUpon = true;
    }

    public void NotGazingUpon()
    {
        isGazingUpon = false;
        
    }
}