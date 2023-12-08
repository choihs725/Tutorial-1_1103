using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangetoHTR : MonoBehaviour
{
    // Start is called before the first frame update
    public void ScenceChange()
    {
        SceneManager.LoadScene("Manual Scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
