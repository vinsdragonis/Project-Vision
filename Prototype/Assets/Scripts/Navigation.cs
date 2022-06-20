using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Navigation : MonoBehaviour
{
    public UIDocument Document;
    public GameObject mainCamera;
    bool camera_move_enabled;
    
    // Start is called before the first frame update
    void Awake() {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        rotateToPosition rpt = mainCamera.GetComponent<rotateToPosition>();

        var root = Document.rootVisualElement;
        var nextBT = root.Q<Button>("Nav_Next");
        var backBT = root.Q<Button>("Nav_Prev");
        var instruction = root.Q<Label>("Instruction");
        if(nextBT != null)
        {
            nextBT.clicked += () => {
                rpt.camera_move_enabled = true;
                rpt.index=(rpt.index+1)%4;
                instruction.text = rpt.instruction;
            };
        }
        if(backBT != null)
        {
            backBT.clicked += () => {
                rpt.camera_move_enabled = true;
                rpt.index=(rpt.index-1)%4;
                instruction.text = rpt.instruction;
            };
        }
    }
    
    
}
