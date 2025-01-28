using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private float orizontal;
    private float vertical;

    public float Sensitivity
    {
        get { return sensitivity; }
        set { sensitivity = value; }
    }
    [Range(0.1f, 9f)] [SerializeField] float sensitivity = 2f;

    [Range(0f, 90f)] [SerializeField] float yRotationLimit = 88f;

    Vector2 rotation = Vector2.zero;
    const string xAxis = "Mouse X";
    const string yAxis = "Mouse Y";

    // Update is called once per frame
    void Update()
    {
       
        orizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 poz,plsss;
        poz = new Vector3(0, 0.6f, 0);
        rotation.x += Input.GetAxis(xAxis) * sensitivity;
        rotation.y += Input.GetAxis(yAxis) * sensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);
        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);
        
        transform.localRotation = xQuat * yQuat;
        
        
         if(Input.GetKey(KeyCode.W))
         {
             player.transform.position += transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime;

         }
         if(Input.GetKey(KeyCode.S))
         {
             player.transform.position += transform.TransformDirection(Vector3.back) * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.A))
         {
             player.transform.position += transform.TransformDirection(Vector3.left) * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.D))
         {
             player.transform.position += transform.TransformDirection(Vector3.right) * speed * Time.deltaTime;
         }
        plsss = player.transform.position;
        plsss.y = 0;
        player.transform.position = plsss;

    }

}
