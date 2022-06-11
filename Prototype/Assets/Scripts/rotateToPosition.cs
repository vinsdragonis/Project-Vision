using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class rotateToPosition : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject TargetPosition;
    public float speed = 2.0f;
    bool camera_move_enabled = false;
    public List<Vector3> positions;
    public List<Quaternion> rotations;

    // Start is called before the first frame update
    void Start()
    {
        positions = new List<Vector3>();
        rotations = new List<Quaternion>();
        positions.Add(new Vector3(-7.75f,12.0f,0.0f));
        rotations.Add(TargetPosition.transform.rotation);
        Invoke("enableCamera", 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (camera_move_enabled)
        {
            MainCamera.transform.position = Vector3.Lerp(transform.position, positions[0], speed * Time.deltaTime);
            MainCamera.transform.rotation = Quaternion.Lerp(transform.rotation, rotations[0], speed * Time.deltaTime);
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
