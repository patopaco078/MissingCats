using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu]
public class InventarioSO : ScriptableObject
{
  public List<InventarioItemSO> inventarioItems;
    [field: SerializeField]
    public int Size { get; private set; } 

    public event Action<Dictionary<int, InventarioItemSO>> OnInventoryUpdated;

    public void Inicialaze()
    {
        inventarioItems = new List<InventarioItemSO>();
        for(int i=0;i<Size;i++)
        {
            inventarioItems.Add(InventarioItemSO.GetEmptyItem());
        }
    }

    public void AddItem(itemSO itemSO)
    {
        for (int i = 0; i < inventarioItems.Count; i++)
        {

          if(inventarioItems[i].IsEmpty)
            {
                inventarioItems[i] = new InventarioItemSO
                {
                    item = itemSO
                    
                };
                return;
            }
        }

        

    }
    public void removeItem(int numero)
    {
        for (int i = 0; i < inventarioItems.Count; i++)
        {
            if (i == numero)
            {
                inventarioItems[i] = new InventarioItemSO
                {
                    item = null

                };
                return;
            }
        }
    }

    public Dictionary<int, InventarioItemSO> GetCurrentInventoryState()
    {
        Dictionary<int, InventarioItemSO> returnvalue = new Dictionary<int, InventarioItemSO>();
        for (int i = 0; i < inventarioItems.Count; i++)
        {
            if(inventarioItems[i].IsEmpty)
                continue;
            returnvalue[i] = inventarioItems[i];


            
            
        }

        return returnvalue;
    }

    public InventarioItemSO GetItemAt(int obj)
    {
        return inventarioItems[obj];
    }
    public void SwapItems(int arg1, int arg2)
    {
        
        InventarioItemSO item1 = inventarioItems[arg1];
        inventarioItems[arg1] = inventarioItems[arg2];
        inventarioItems[arg2] = item1;
        informAbautchange();
    }
    private void informAbautchange()
    {
        OnInventoryUpdated?.Invoke(GetCurrentInventoryState());
    }

   
}

[Serializable]
public struct InventarioItemSO
{
    public itemSO item;
    public bool IsEmpty => item == null;

    public static InventarioItemSO GetEmptyItem() => new InventarioItemSO
    {
        item = null
    };
}