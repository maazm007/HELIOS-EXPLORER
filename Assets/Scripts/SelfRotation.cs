using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0.05f, 0f));

    }
}