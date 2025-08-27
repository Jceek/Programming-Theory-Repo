using UnityEngine;
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
}
