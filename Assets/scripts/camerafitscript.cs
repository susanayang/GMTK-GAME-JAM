using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class camerafitscript : MonoBehaviour
{
    public float ratio = 16f / 9f;
    RectTransform r;


    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<RectTransform>();
        float screenratio = (float)Screen.width / Screen.height;
        if (screenratio > ratio)
        {
            r.sizeDelta = new Vector2(r.sizeDelta.y * screenratio, r.sizeDelta.y);
        }
        else if (screenratio < 1 / ratio)
        {
            r.sizeDelta = new Vector2(r.sizeDelta.x, r.sizeDelta.x/screenratio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
