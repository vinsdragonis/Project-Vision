using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


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
        var prevBT = root.Q<Button>("Nav_Prev");
        var backBT = root.Q<Button>("BackButton");
        var instruction = root.Q<Label>("Instruction");
        if(nextBT != null)
        {
            nextBT.clicked += () => {
                rpt.camera_move_enabled = true;
                if(rpt.index < 4) 
                    rpt.index = (rpt.index + 1) ;
                instruction.text = rpt.instruction+rpt.index;
            };
        }
        if(prevBT != null)
        {
            prevBT.clicked += () => {
                rpt.camera_move_enabled = true;
                if(rpt.index>1)
                    rpt.index = (rpt.index - 1) ;
                // if(rpt.index < 0) rpt.index = 5;
                instruction.text = rpt.instruction+rpt.index;
            };
        }
        if(backBT != null)
        {
            backBT.clicked += () => {
                LoadNextScene(-1);
            };
            
        }
    }
    public void LoadNextScene(int dir) 
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + dir;
        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
    
    
}
