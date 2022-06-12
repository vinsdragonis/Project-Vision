using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class rotateToPosition : MonoBehaviour
{
    public GameObject MainCamera;
    //public GameObject TargetPosition;
    public float speed = 2.0f;
    bool camera_move_enabled = false;
    public List<Vector3> positions;
    public List<Vector3> rotationsEuler;
    private Quaternion rotation;
    public int index=0;

    // Start is called before the first frame update
    void Start()
    {
        ViewData view = gameObject.GetComponent<ViewData>();
        positions = view.positions;
        rotationsEuler = view.rotationsEuler;
        index=0;
        
        Invoke("enableCamera", 3);
    }

    // Update is called once per frame
    void Update()
    {
        rotation.eulerAngles = rotationsEuler[index];
        if (camera_move_enabled)
        {
            rotation.eulerAngles = rotationsEuler[index];
            MainCamera.transform.position = Vector3.Lerp(transform.position, positions[index], speed * Time.deltaTime);
            MainCamera.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
    }

    void enableCamera() {
        camera_move_enabled = true;
    }

    // public void UserClickedCameraResetButton()
    // {
    //     TargetPosition.transform.position = new Vector3(-106.2617f, 68.81419f, 14.92558f);
    //     TargetPosition.transform.rotation = Quaternion.Euler(39.7415f, 145.0724f, 0);
    //     camera_move_enabled = true;
    // }
}
