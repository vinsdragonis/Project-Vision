using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTemp : MonoBehaviour
{
    public float m_Speed;
    public bool m_WorldSpace;
    //double radius = 2.0,x,y,z;

    void Start()
    {
        //Set the speed of the rotation
        //m_Speed = 100.0f;
        //Rotate the GameObject a little at the start to show the difference between Space and Local
        //transform.Rotate(60, 0, 60);
    }

    // void Update()
    // {
    //     //Rotate the GameObject in World Space if in the m_WorldSpace state
    //     if(Input.GetKeyDown(KeyCode.UpArrow))
    //     {if (m_WorldSpace)
    //         transform.Rotate(Vector3.up * m_Speed * Time.deltaTime, Space.World);
    //     //Otherwise, rotate the GameObject in local space
    //     else
    //         transform.Rotate(Vector3.up * m_Speed * Time.deltaTime, Space.Self);
    //     }
    //     if(Input.GetKeyDown(KeyCode.DownArrow))
    //     {if (m_WorldSpace)
    //         transform.Rotate(Vector3.down * m_Speed * Time.deltaTime, Space.World);
    //     //Otherwise, rotate the GameObject in local space
    //     else
    //         transform.Rotate(Vector3.down * m_Speed * Time.deltaTime, Space.Self);
    //     }
    //     if(Input.GetKeyDown(KeyCode.RightArrow))
    //     {if (m_WorldSpace)
    //         transform.Rotate(Vector3.right * m_Speed * Time.deltaTime, Space.World);
    //     //Otherwise, rotate the GameObject in local space
    //     else
    //         transform.Rotate(Vector3.right * m_Speed * Time.deltaTime, Space.Self);}
        
    //     if(Input.GetKeyDown(KeyCode.LeftArrow))
    //     {if (m_WorldSpace)
    //         transform.Rotate(Vector3.left * m_Speed * Time.deltaTime, Space.World);
    //     //Otherwise, rotate the GameObject in local space
    //     else
    //         transform.Rotate(Vector3.left * m_Speed * Time.deltaTime, Space.Self);}

    //     //Press the Space button to switch between world and local space states
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         //Make the current state switch to the other state
    //         m_WorldSpace = !m_WorldSpace;
    //         //Output the Current state to the console
    //         Debug.Log("World Space : " + m_WorldSpace.ToString());
    //     }
    // }

    private void Update() {
        
    }
}