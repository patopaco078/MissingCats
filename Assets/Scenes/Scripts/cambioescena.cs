using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioescena : MonoBehaviour
{
    
    public void loadscene(int a)
    {
        SceneManager.LoadScene(a);
    }
  
}
