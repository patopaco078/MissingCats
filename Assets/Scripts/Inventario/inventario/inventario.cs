using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu]
public class inventario : ScriptableObject
{

    public event Action<Dictionary<int,inventario>> onInventaryUpdated;

    [SerializeField]private List<inventario> inventarioLista;

    [field: SerializeField]

    public int Size{get ; private set;} =12;

    public void Initialize()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
