using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafitscript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.aspect = (float)Screen.width / Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
