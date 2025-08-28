using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenHandler : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "1_Abstraction")
        {
            SceneManager.LoadScene(2);
        }
        if (sceneName == "2_Inheritance")
        {
            SceneManager.LoadScene(3);
        }
        if (sceneName == "3_Polymorphism")
        {
            SceneManager.LoadScene(4);
        }

    }
    public void PreviousScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "2_Inheritance")
        {
            SceneManager.LoadScene(1);
        }
        if (sceneName == "3_Polymorphism")
        {
            SceneManager.LoadScene(2);
        }
        if (sceneName == "4_Encapsulation")
        {
            SceneManager.LoadScene(3);
        }
    }
    public void LoadAbstraction()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadInheritance()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadPolymorphism()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadEncapsulation()
    {
        SceneManager.LoadScene(4);
    }
    public void BackToTitle()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitApplication()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else   
        Application.Quit(); 
#endif
    }
}
