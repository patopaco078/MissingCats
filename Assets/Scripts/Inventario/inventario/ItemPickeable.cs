using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemPickeable : MonoBehaviour
{

   [field: SerializeField]
    public itemSO itemInventorio { get; private set; }
    [SerializeField] private UnityEvent doThis;



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
        doThis.Invoke();
        gameObject.SetActive(false);
        
    }
}
