using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Navigation : MonoBehaviour
{
    public UIDocument Document;
    public GameObject mainCamera;
    
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
                rpt.index+=1;
                instruction.text = rpt.index.ToString();
            };
        }
        if(backBT != null)
        {
            backBT.clicked += () => {
                rpt.index-=1;
                instruction.text = rpt.index.ToString();
            };
        }
    }
    
    
}
