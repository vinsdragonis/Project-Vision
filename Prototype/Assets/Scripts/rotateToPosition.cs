using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class rotateToPosition : MonoBehaviour
{
    public GameObject MainCamera;
    //public GameObject TargetPosition;
    public float speed = 2.0f;
    public bool camera_move_enabled = false;
    public List<Vector3> positions;
    public List<Vector3> rotationsEuler;
    private Quaternion rotation;
    private Vector3 position;
    public int index = 0;
    bool isRotated = false;
    bool isRotating = false;
    List<string> instructions;
    public string instruction;
    ViewData view;

    // Start is called before the first frame update
    void Start()
    {
        view = gameObject.GetComponent<ViewData>();
        positions = view.positions;
        rotationsEuler = view.rotationsEuler;
        instructions = view.instructions;
        index = 0;

        Invoke("enableCamera", 2);
    }

    // Update is called once per frame
    void Update()
    {
        isRotated = gameObject.GetComponent<roateAround>().rotated;
        isRotating = gameObject.GetComponent<RotateCamera>().isRotating;
        instruction=instructions[index];
        if (isRotating) {
            camera_move_enabled = false;
        } else {
            camera_move_enabled = true;
        }

        if (isRotated && camera_move_enabled)
        {
            rotation.eulerAngles = rotationsEuler[index];
            MainCamera.transform.position = Vector3.Lerp(transform.position, positions[index], speed * Time.deltaTime);
            MainCamera.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
        instruction=view.instructions[index];
    }
    void changePosition() {
        position = positions[index];
        rotation.eulerAngles = rotationsEuler[index];
    }

    void enableCamera() {
        camera_move_enabled = true;
    }

   
}
