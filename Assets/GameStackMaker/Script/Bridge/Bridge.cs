using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    [SerializeField] GameObject bridge;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Stack stacking = other.GetComponent<Stack>();

            if (stacking.bricks.Count > 0 && !bridge.activeSelf)
            {
                bridge.SetActive(true);
                stacking.RemoveBrick();
            }

        }

    }
}
