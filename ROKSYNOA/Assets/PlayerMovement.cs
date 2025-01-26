using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.forward * speed * Time.deltaTime;
            Debug.Log("blabla");
        }
        if(Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.back  * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

}
