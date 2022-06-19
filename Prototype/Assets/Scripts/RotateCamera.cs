using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] Camera cameraObj;
    [SerializeField] GameObject myGameObj;
    [SerializeField] float speed = 4f;
    //[SerializeField] new GameObject gameObject;
    Quaternion angle;
    bool isRotated = true;
    // float zoom = 0f;
    public bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isRotated = gameObject.GetComponent<roateAround>().rotated;
        if (isRotated == true)
        {   
            rotateCamera();
        }
    }


    void rotateCamera()
    {
        if (Input.GetMouseButton(0))
        {
            cameraObj.transform.RotateAround(myGameObj.transform.position,
                                            cameraObj.transform.up,
                                            Input.GetAxis("Mouse X") * speed);

            cameraObj.transform.RotateAround(myGameObj.transform.position,
                                            cameraObj.transform.right,
                                            -Input.GetAxis("Mouse Y") * speed);

            isRotating = true;
        // } else if (Input.GetMouseButton(1)) {
        //     zoom+=0.001f;
        //     transform.position = Vector3.MoveTowards(transform.position, myGameObj.transform.position, zoom);
        // } else if (Input.GetMouseButton(2)) {
        //     zoom-=0.001f;
        //     transform.position = Vector3.MoveTowards(transform.position, myGameObj.transform.position, zoom);
        } else {
            isRotating = false;
        }
        
        angle.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        transform.rotation = angle;
    }
    void viewMode() {
        isRotated = !isRotated;
    }

}
