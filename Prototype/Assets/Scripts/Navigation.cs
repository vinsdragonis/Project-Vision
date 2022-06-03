using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Navigation : MonoBehaviour
{
    public UIDocument Document;
    int index=0;
    
    // Start is called before the first frame update
    void Awake() {
        
        var root = Document.rootVisualElement;
        var nextBT = root.Q<Button>("Nav_Next");
        var backBT = root.Q<Button>("Back_Next");
        var instruction = root.Q<Label>("Instruction");
        if(nextBT != null)
        {
            nextBT.clicked += () => {
                index+=1;
                instruction.text = index.ToString();
            };
        }
    }
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    
}
