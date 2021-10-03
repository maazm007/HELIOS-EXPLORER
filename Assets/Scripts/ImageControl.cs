using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageControl : MonoBehaviour
{
    public bool isImgOn;
    public Image img;
    public void OnMouseDown()
    {
        if (isImgOn == false)
        {
            img.enabled = true;
            isImgOn = true;
        }
        else
        {
            img.enabled = false;
            isImgOn = false;
        }
    }
}
