using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTrans : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("LoadSceneByIndex", 10);
    }
    public void LoadSceneByIndex()
    {
        SceneManager.LoadScene(2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
