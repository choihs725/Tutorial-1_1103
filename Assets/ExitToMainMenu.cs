using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ScenceChange()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
