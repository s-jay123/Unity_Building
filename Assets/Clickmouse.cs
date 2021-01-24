using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickmouse : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity = 100.0f;
    float xrotation =0f; 

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // rotate the entire body of the player around X axis and also look up and down.
        float forwardX = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y");
        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
     
        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        // making the player move forward and backward



    }
}
