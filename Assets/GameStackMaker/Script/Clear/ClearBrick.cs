using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearBrick : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Lấy component Stack từ Player
            Stack playerStack = other.gameObject.GetComponent<Stack>();

            if (playerStack != null)
            {
                // Xóa từng brick một từ cuối stack
                while (playerStack.bricks.Count > 0)
                {
                    playerStack.RemoveBrick();
                }
            }
        }
    }
}