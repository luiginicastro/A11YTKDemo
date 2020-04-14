using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCCTrigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<A11YTK.SubtitleAudioSourceController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<A11YTK.SubtitleAudioSourceController>().enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<A11YTK.SubtitleAudioSourceController>().enabled = false;
        }
    }

}
