using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseZoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera>().fieldOfView--;
            //GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y-.3f, transform.position.z+.2f);
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().fieldOfView++;
            //GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y-.3f, transform.position.z+.2f);
        }
    }
}
