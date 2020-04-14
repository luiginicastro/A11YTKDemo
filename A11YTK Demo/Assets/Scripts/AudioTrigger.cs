using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource clip;
    public Animator animController;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clip.Play();
            animController.SetBool("Play", true);
        }
    }
}
