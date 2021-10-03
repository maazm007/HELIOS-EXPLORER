using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GOOG : MonoBehaviour
{
    public bool isImgOn;
    public Image img;
    public void OnMouseDown()
    {
        if (isImgOn == false)
        {
            img.gameObject.SetActive(true);
            isImgOn = true;

        }
        else
        {
            img.gameObject.SetActive(false);
        }
    }
}
