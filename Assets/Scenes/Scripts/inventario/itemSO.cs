using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class itemSO : ScriptableObject
{

    public int ID => GetInstanceID();
    
      [field: SerializeField]
    public string Name { get; set; }

    [field: SerializeField]
    public Sprite itemImagen { get; set; }

    [field: SerializeField]
    [field: TextArea]
    public string Description { get; set; }

}
