using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishNextMap : MonoBehaviour
{
    public GameObject MenuNextLevel;
    public GameObject PauseButton;
    public GameObject objectToEnable;
    public GameObject objectToDisable;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (MenuNextLevel != null)
                MenuNextLevel.SetActive(true);

            if (objectToEnable != null)
                objectToEnable.SetActive(true);

            if (objectToDisable != null)
                objectToDisable.SetActive(false);

            if (PauseButton != null)
                PauseButton.SetActive(false);
        }

    }

}
