using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] Camera cameraObj;
    [SerializeField] GameObject myGameObj;
    [SerializeField] float speed = 4f;
    [SerializeField] new GameObject gameObject;
    bool isRotated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isRotated = gameObject.GetComponent<roateAround>().rotated;
        rotateCamera();
    }


    void rotateCamera()
    {
        if (isRotated == true)
        {
            if (Input.GetMouseButton(0))
            {
                cameraObj.transform.RotateAround(myGameObj.transform.position,
                                                cameraObj.transform.up,
                                                Input.GetAxis("Mouse X") * speed);

                // cameraObj.transform.RotateAround(myGameObj.transform.position,
                //                                 cameraObj.transform.right,
                //                                 -Input.GetAxis("Mouse Y") * speed);
            }
        }
    }
}
