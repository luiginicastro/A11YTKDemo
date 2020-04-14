using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Video;

public class Remote : MonoBehaviour
{
    
    public VideoPlayer video;
    public AudioSource clip;


    private void Awake()
    {
        GetComponent<PrimaryButtonWatcher>().enabled = false;
    }
    public void UseRemote()
    {
            video.Play();
            clip.Play();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<PrimaryButtonWatcher>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<PrimaryButtonWatcher>().enabled = false;
        }
    }
}
