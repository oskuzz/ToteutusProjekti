using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void exit()
    {
        Application.Quit();
    }

    public void newSave()
    {
        
        
    }

    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
