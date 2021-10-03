using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour
{
    public Image Image1,Image2,Image3,Image4;

    public void Start()
    {
        Invoke("Show", 20f);    
    }
    void Show()
    {
        Image1.gameObject.SetActive(true);
        Image2.gameObject.SetActive(true);
        Image3.gameObject.SetActive(true);
        Image4.gameObject.SetActive(true);
        Invoke("Hide", 10f);
    }
    void Hide()
    {
        Image1.gameObject.SetActive(false);
        Image2.gameObject.SetActive(false);
        Image3.gameObject.SetActive(false);
        Image4.gameObject.SetActive(false);
    }

}
