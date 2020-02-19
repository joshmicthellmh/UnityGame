using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public string Location;
    public string Location2;
    
    public void LoadScene()
  
    {
        
        SceneManager.LoadScene(Location);
         
    }
    public void LoadScene2()

    {
        SceneManager.LoadScene(Location2);

    }

}
