using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickeable : MonoBehaviour
{

   [field: SerializeField]
public itemSO itemInventorio { get; private set; }

    [SerializeField]
    private AudioSource sonido;

  

    // Start is called before the first frame update
    void Start()
    {
      
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyItem()
    {
        sonido.Play();
        gameObject.SetActive(false);
        
    }
}
