using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollider : MonoBehaviour,IInterectableObject
{
    [SerializeField] private bool isRightCollider;



    public float GetRotate()
    {
        if (isRightCollider)
            return 90f;

        return -90f;
    }
}
