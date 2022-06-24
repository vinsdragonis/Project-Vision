using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class NavigationProduct : MonoBehaviour
{
    public UIDocument Document;
    // Start is called before the first frame update
    void Awake() 
    {
        var root = Document.rootVisualElement;
        var instBT = root.Q<Button>("ToInstruction");
        var backBT = root.Q<Button>("Back");
        // var productImg = root.Q<VisualElement>("ProductImage");
        // productImg.style.width = new Length(300,LengthUnit.Pixel);
        // productImg.style.height = new Length(200,LengthUnit.Pixel);
        Screen.orientation = ScreenOrientation.Portrait;
        if(instBT != null)
        {
            instBT.clicked += () => {
                LoadNextScene(1);
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
