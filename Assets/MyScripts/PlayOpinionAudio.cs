using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOpinionAudio : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void OnCollisionEnter(Collision collision)
    {
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.white);
        //}
        //if (collision.relativeVelocity.magnitude > 2)
        //    audioSource.Play();
        audioSource.Play();
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}