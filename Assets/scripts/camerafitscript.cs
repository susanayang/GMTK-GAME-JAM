using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class camerafitscript : MonoBehaviour
{
    public float camsize;
    public float ratio = Screen.width*1.0f / Screen.height;
    public float camheight = 10;
    public float camwidth=5.625f;


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.aspect = (float)Screen.width / Screen.height;
        float camorthosize = this.GetComponent<Camera>().orthographicSize;
        float newcamwidth = camorthosize * 2 * ratio;
        if (newcamwidth < camwidth)
        {
            camorthosize = camwidth / (2 * ratio);
            this.GetComponent<Camera>().orthographicSize = camorthosize;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
