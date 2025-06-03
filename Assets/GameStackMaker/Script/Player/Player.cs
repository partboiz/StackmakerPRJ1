using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InputDirection;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask brickLayerMask;
    [SerializeField] float moveSpeed = 5f;
    Vector3 targetPos;
    Vector3 direction;
    private bool isMoving = false; // Thêm biến kiểm tra trạng thái di chuyển

    private void Start()
    {
        targetPos = transform.position;
    }

    private void Update()
    {
        MoveLocation();
    }

    private void OnEnable()
    {
        InputDirection.Swipe += Move;
    }

    private void OnDisable()
    {
        InputDirection.Swipe -= Move;
    }

    private void Move(SwipeDirection swipe)
    {
        // Chỉ cho phép di chuyển nếu không trong trạng thái di chuyển
        if (!isMoving)
        {
            switch (swipe)
            {
                case SwipeDirection.Left:
                    direction = Vector3.left;
                    break;
                case SwipeDirection.Right:
                    direction = Vector3.right;
                    break;
                case SwipeDirection.Up:
                    direction = Vector3.forward;
                    break;
                case SwipeDirection.Down:
                    direction = Vector3.back;
                    break;
            }
            RaycastHit hit;
            for (int i = 1; i <= 50; i++)
            {
                if (Physics.Raycast(transform.position + direction * i + Vector3.up * 3.5f, Vector3.down, out hit, brickLayerMask))
                {
                    Debug.DrawRay(transform.position + direction * i + Vector3.up * 3.5f, Vector3.down, Color.red, 1f);
                    targetPos = hit.collider.transform.position;
                    targetPos.y = transform.position.y;
                }
                else
                {
                    return;
                }
            }
        }
    }

    private void MoveLocation()
    {
        if (Vector3.Distance(transform.position, targetPos) < 0.02f)
        {
            isMoving = false; // Đánh dấu kết thúc di chuyển
            return;
        }

        isMoving = true; // Đánh dấu đang di chuyển
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

}