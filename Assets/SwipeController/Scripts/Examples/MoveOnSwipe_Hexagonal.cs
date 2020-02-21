using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GG.Infrastructure.Utils.Swipe;

public class MoveOnSwipe_Hexagonal : MonoBehaviour
{
    [Header("Available movements:")]

    [SerializeField] private bool _up = true;
    [SerializeField] private bool _down = true;
    [SerializeField] private bool _left = true;
    [SerializeField] private bool _right = true;
    [SerializeField] private bool _upLeft = true;
    [SerializeField] private bool _upRight = true;
    [SerializeField] private bool _downLeft = true;
    [SerializeField] private bool _downRight = true;



    public void OnSwipeHandler(string id)
    {
        switch(id)
        {
            case DirectionId.ID_UP:
                MoveUp();
                break;

            case DirectionId.ID_DOWN:
                MoveDown();
                break;

            case DirectionId.ID_LEFT:
                MoveLeft();
                break;

            case DirectionId.ID_RIGHT:
                MoveRight();
                break;

            case DirectionId.ID_UP_LEFT:
                MoveUpLeft();
                break;

            case DirectionId.ID_UP_RIGHT:
                MoveUpRight();
                break;

            case DirectionId.ID_DOWN_LEFT:
                MoveDownLeft();
                break;

            case DirectionId.ID_DOWN_RIGHT:
                MoveDownRight();
                break;
        }
    }

    private void MoveDownRight()
    {
        if (_downRight)
        {
            transform.position += Vector3.down + Vector3.right * 0.5f;
        }
    }

    private void MoveDownLeft()
    {
        if (_downLeft)
        {
            transform.position += Vector3.down + Vector3.left * 0.5f;
        }
    }

    private void MoveUpRight()
    {
        if (_upRight)
        {
            transform.position += Vector3.up + Vector3.right * 0.5f;
        }
    }

    private void MoveUpLeft()
    {
        if (_upLeft)
        {
            transform.position += Vector3.up + Vector3.left * 0.5f;
        }
    }

    private void MoveRight()
    {
        if (_right)
        {
            transform.position += Vector3.right;
        }
    }

    private void MoveLeft()
    {
        if (_left)
        {
            transform.position += Vector3.left;
        }
    }

    private void MoveDown()
    {
        if (_down)
        {
            transform.position += Vector3.down;
        }
    }

    private void MoveUp()
    {
        if (_up)
        {
            transform.position += Vector3.up;
        }
    }
}
