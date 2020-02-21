using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveOnSwipe_Vector : MonoBehaviour
{

    public void Move(Vector3 movement)
    {
        transform.position += movement;
    }
}
