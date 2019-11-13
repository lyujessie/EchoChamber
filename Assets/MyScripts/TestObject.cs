using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour, iGazeReceiver
{
    private bool isGazingUpon;
    public AudioSource opinion_audio;

    // Start is called before the first frame update
    void Start()
    {
        opinion_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGazingUpon)
        {
            // Do anything you want here, we'll rotate for this demo
            // transform.Rotate(0, 3, 0);
            opinion_audio.Play(); // Playing the audio file associated with opinion_audio

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
