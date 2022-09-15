using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class cambioescena : MonoBehaviour
{

    public RectTransform main, ajustes, niveles;

    // Start is called before the first frame update
    

    public void loadscene(int a)
    {
        SceneManager.LoadScene(a);
    }

    public void botonAjustes()
    {
        //main.DOAnchorPos(new Vector2(-1000, 0), 0.25f);
        //ajustes.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void vueltajustes() 
    { 
      //  main.DOAnchorPos(new Vector2(0, 0), 0.5f);
        //ajustes.DOAnchorPos(new Vector2(0, 800), 0.25f);
    }
    public void botoniveles()
    {
        //main.DOAnchorPos(new Vector2(-1000, 0), 0.25f);
        //niveles.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void vueltaniveles()
    {
        //main.DOAnchorPos(new Vector2(0, 0), 0.25f);
        //niveles.DOAnchorPos(new Vector2(1000, 0), 0.25f);
    }
}

