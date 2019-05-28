using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShowMyApp_API;
using UnityEngine.SceneManagement;

public class FakeSceneController : MonoBehaviour
{
    public ShowMyApp MyShowMyApp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShareAction()
    {
        if (MyShowMyApp != null)
        {
            SceneManager.LoadScene("ShowMyAppScene", LoadSceneMode.Additive);
        }
    }
}
