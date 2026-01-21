using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void SwitchToScene(string sceneName)
    {
      SceneManager.LoadScene(sceneName);
    }



}
