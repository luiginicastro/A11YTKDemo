using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipTrigger : MonoBehaviour
{
    
    void Start()
    {
       GetComponent<A11YTK.TooltipController>().enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<A11YTK.TooltipController>().enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<A11YTK.TooltipController>().enabled = false;
        }
    }

}
