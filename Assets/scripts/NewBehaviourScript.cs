using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += (Vector3.up * movespeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += (Vector3.left * movespeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += (Vector3.down * movespeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += (Vector3.right * movespeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movespeed = 10;
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            movespeed = 2;
        }
        else
        {
            movespeed = 5;
        }
    }
}
