using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bop : MonoBehaviour {

    public Transform lightSpot;
    public Light generatedLight;
    public AudioSource bopSource;


    // Start is called before the first frame update
    void Start()
    {
    bopSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            Debug.Log("Collision!"); // I can use Debug.Log to generate console messages for debugging
            bopSource.Play(); // Playing the audio file associated with bopSource
            Instantiate(generatedLight, lightSpot.position, lightSpot.rotation); // I'll instantiate a light that I'll store in the public light "generatedLight," and I'll put it at a position and rotation specified by an empty game object called by lightSpot
        }
    }
}
