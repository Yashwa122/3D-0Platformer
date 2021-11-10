using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed = 3.0f;
    float rotation = 0.0f;
    float camRotaion = 1.0f;
    GameObject cam;
    float rotaionSpeed = 2.0f;
    float camRotaionSpeed = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);
        transform.position = transform.position + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);

        rotation = rotation + Input.GetAxis("Mouse X") * rotaionSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotaion = camRotaion + Input.GetAxis("Mouse Y") * camRotaionSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(-camRotaion, 0.0f, 0.0f));
    }
}
