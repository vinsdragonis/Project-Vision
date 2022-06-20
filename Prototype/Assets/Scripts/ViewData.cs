using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewData :MonoBehaviour
{
    public List<Vector3> positions;
    public List<Vector3> rotationsEuler;
    public List<string> instructions;

    private void Awake() {
        positions.Add(new Vector3(0f,4.96f,-20.45f));
        positions.Add(new Vector3(-7.75f,16f,0.0f));
        positions.Add(new Vector3(0f,4.96f,-20.45f));
        positions.Add(new Vector3(9.802f,2.734f,-9f));
        positions.Add(new Vector3(0f,4.96f,-20.45f));
        positions.Add(new Vector3(0f,4.96f,-20.45f));
        rotationsEuler.Add(new Vector3(0,0,0));
        rotationsEuler.Add(new Vector3(90,0,0));
        rotationsEuler.Add(new Vector3(0,0,0));
        rotationsEuler.Add(new Vector3(0,0,0));
        rotationsEuler.Add(new Vector3(0,0,0));
        rotationsEuler.Add(new Vector3(0,0,0));
        instructions.Add("Press the highlighted button to power on the device");
        instructions.Add("The display has been turned on");
        instructions.Add("Press the home button once");
        instructions.Add("Your device has been unlocked");

    }
    
}
