using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roateAround : MonoBehaviour
{
    public GameObject c;
    [SerializeField] GameObject target;
    [SerializeField] int rSpeed;
    [SerializeField] public bool rotated = false;

    // Start is called before the first frame update
    void Start()
    {
        c.transform.rotation = Quaternion.Euler(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (rotated == false && c.transform.localRotation.eulerAngles.y > 1 || c.transform.localRotation.eulerAngles.y < -1) {
            transform.RotateAround(target.transform.position, Vector3.up, rSpeed * Time.deltaTime);
        }

        if (c.transform.localRotation.eulerAngles.y > -1 && c.transform.localRotation.eulerAngles.y < 1)
        {
            rotated = true;
        }
    }
}
