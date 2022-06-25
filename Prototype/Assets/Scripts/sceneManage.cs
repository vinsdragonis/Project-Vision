using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class sceneManage : MonoBehaviour
{
    public UIDocument Document;

    private void Awake() {
        var root = Document.rootVisualElement;
        var viewBT = root.Q<Button>("ViewBTN");
        var exitBT = root.Q<Button>("ExitBTN");

        if(viewBT != null)
        {
            viewBT.clicked += () => {
                LoadNextScene();
            };
        }
        if(exitBT != null)
        {
            exitBT.clicked += () => {
                Application.Quit();
            };
        }
    }
    public void LoadNextScene() 
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
