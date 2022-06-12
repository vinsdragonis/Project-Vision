using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewData :MonoBehaviour
{
    public List<Vector3> positions;
    public List<Vector3> rotationsEuler;

    private void Awake() {
        positions.Add(new Vector3(-7.75f,16f,0f));
        positions.Add(new Vector3(9.802f,2.734f,-12f));
        rotationsEuler.Add(new Vector3(90,0,0));
        rotationsEuler.Add(new Vector3(0,0,0));
    }
    
}
