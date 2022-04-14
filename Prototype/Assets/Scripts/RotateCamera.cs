using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] Camera cameraObj;
    [SerializeField] GameObject myGameObj;
    [SerializeField] float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateCamera();
    }


    void rotateCamera()
    {
        if (Input.GetMouseButton(0))
        {
            cameraObj.transform.RotateAround(myGameObj.transform.position,
                                            cameraObj.transform.up,
                                            -Input.GetAxis("Mouse X") * speed);

            // cameraObj.transform.RotateAround(myGameObj.transform.position,
            //                                 cameraObj.transform.right,
            //                                 -Input.GetAxis("Mouse Y") * speed);
        }
    }
}
