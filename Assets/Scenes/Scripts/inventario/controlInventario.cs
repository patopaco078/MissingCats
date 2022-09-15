using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlInventario : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private inventariopagina inventariopagina;
    [SerializeField]
    private InventarioSO inventarioData;


    List<InventarioItemSO> initialItems = new List<InventarioItemSO>();

    public void Start()
    {
        inventarioData.Inicialaze();
        PrepareUI();
        


        PrepareInventoryData();
    }

    private void PrepareInventoryData()
    {
        
        inventarioData.Inicialaze();
        inventarioData.OnInventoryUpdated += UpDateInventoryUI;
        foreach (InventarioItemSO item in initialItems)
        {
            if(item.IsEmpty)
            {
                inventarioData.AddItem(item.item);
            }
        }
    }

    private void UpDateInventoryUI(Dictionary<int, InventarioItemSO> obj)
    {
        inventariopagina.ResetAllItems();

        foreach (var item in obj)
        {
            inventariopagina.UpDateData(item.Key, item.Value.item.itemImagen);
        }

    }

    private void PrepareUI()
    {
        inventariopagina.IniciarInventario(inventarioData.Size);
        this.inventariopagina.OnDescriptionRequest += HandleDescriptionRequest;
        this.inventariopagina.OnSwapItem += HandleSwapItems;
        this.inventariopagina.OnStartDraggin += HandleDragging;
        this.inventariopagina.OnItemAction += HandleItemActionRequest;
    }

    private void HandleItemActionRequest(int obj)
    {
        throw new NotImplementedException();
    }

    private void HandleDragging(int obj)
    {
        InventarioItemSO inventarioI = inventarioData.GetItemAt(obj);
        inventariopagina.createdDraggedItem(inventarioI.item.itemImagen);
    }

    private void HandleSwapItems(int arg1, int arg2)
    {
        inventarioData.SwapItems(arg1, arg2);
        
    }

    private void HandleDescriptionRequest(int obj)
    {
      
        InventarioItemSO itemI = inventarioData.GetItemAt(obj);
        if (itemI.IsEmpty)
        {
            inventariopagina.ResetSelection();
            inventariopagina.Hide();
            return;
        }
        else
        {
            inventariopagina.showDescription();
            itemSO iSO = itemI.item;
            inventariopagina.UpDateDescription(obj, iSO.activarImagen, iSO.itemImagen,iSO.itemImagenDescripción, iSO.Name, iSO.Description);

        }
       

    }

    public void Update()
    {
        foreach (var item in inventarioData.GetCurrentInventoryState())
        {
            inventariopagina.UpDateData(item.Key, item.Value.item.itemImagen);

        }

    }

    void Task()
    {
        
           
               
       
               
        }
    
}
