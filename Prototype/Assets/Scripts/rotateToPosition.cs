using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateToPosition : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject TargetPosition;
    public float speed = 2.0f;
    bool camera_move_enabled = false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("enableCamera", 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (camera_move_enabled)
        {
            MainCamera.transform.position = Vector3.Lerp(transform.position, TargetPosition.transform.position, speed * Time.deltaTime);
            MainCamera.transform.rotation = Quaternion.Lerp(transform.rotation, TargetPosition.transform.rotation, speed * Time.deltaTime);
        }
    }

    void enableCamera() {
        camera_move_enabled = true;
    }

    public void UserClickedCameraResetButton()
    {
        TargetPosition.transform.position = new Vector3(-106.2617f, 68.81419f, 14.92558f);
        TargetPosition.transform.rotation = Quaternion.Euler(39.7415f, 145.0724f, 0);
        camera_move_enabled = true;
    }
}
