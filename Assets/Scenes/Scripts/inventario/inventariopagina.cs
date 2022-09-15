using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventariopagina : MonoBehaviour
{
    [SerializeField]
    private inventarioItem itemprefab;
    [SerializeField]
    private RectTransform contentPanel;



public  Button cierre;

    public GameObject UIDes;

[SerializeField] private inventarioDescripcion descripcion;

    [SerializeField] private mouseFollower mouse;

    public event Action<int> OnDescriptionRequest, OnItemAction, OnStartDraggin;
    public event Action<int, int> OnSwapItem;
       List<inventarioItem> listaDeItems= new List<inventarioItem>();

    private int currentDraggedIndex = -1;

    public void UpDateData(int indexItem,Sprite spriteImagen)
    {
        if(listaDeItems.Count>indexItem)
        {
            listaDeItems[indexItem].setData(spriteImagen);
        }
    }
     private  void Awake()
       {
        mouse.Toggle(false);
        Hide();
        descripcion.ResetDescription();
        
       }

       public void IniciarInventario(int tamanoInventario)
       {
       for(int i=0;i<tamanoInventario;i++)
       {
            inventarioItem itemUI = Instantiate(itemprefab, Vector3.zero, Quaternion.identity);
        itemUI.transform.SetParent(contentPanel);
        listaDeItems.Add(itemUI);
        itemUI.OnItemClicked+=HandleItemSelection;
            itemUI.OnItemBeginDrag += HandleBEginDrag;
            itemUI.OnItemDroppedOn+=HandleSwap;
            itemUI.OnItemEndDrag+=HandleEndDrag;
            itemUI.OnRightMouseBtnClick+=HandleShowItemActions;
       }
       }

    internal void ResetAllItems()
    {
        foreach (var item in listaDeItems)
        {
            item.ResetData();
            item.Deselect();
        }
    }

    public void UpDateDescription(int obj, Sprite itemImagen, string name, string description)
    {
        Debug.Log("Algo");
       
        descripcion.SetDescription(itemImagen, name, description);
        
        DeselectAllItems();
        listaDeItems[obj].Select();
    }



   

    private void HandleShowItemActions(inventarioItem obj)
    {
     
    }

    private void HandleEndDrag(inventarioItem obj)
    {
        ResetDraggedItem();
        mouse.Toggle(false);
    }

    private void HandleSwap(inventarioItem obj)
    {
        int index = listaDeItems.IndexOf(obj);
        if (index == -1)
        {
           
            return;

        }

        OnSwapItem?.Invoke(currentDraggedIndex, index);
        HandleItemSelection(obj);
    }

    private void ResetDraggedItem()
    {
        mouse.Toggle(false);
        currentDraggedIndex = -1;
    }

    private void HandleBEginDrag(inventarioItem obj)
    {
        int index = listaDeItems.IndexOf(obj);
        if (index == -1)
            return;
        currentDraggedIndex = index;
        HandleItemSelection(obj);
        OnStartDraggin?.Invoke(index);
    }

    public void createdDraggedItem(Sprite sprite)
    {
        Debug.Log("hola");
        mouse.Toggle(true);
        mouse.SetData(sprite);
    }

    private void HandleItemSelection(inventarioItem obj)
    {
        int index = listaDeItems.IndexOf(obj);
        if (index == -1)
            return;
        OnDescriptionRequest?.Invoke(index);

    }

    public void Show()
       {
        gameObject.SetActive(true);
        
        ResetSelection();
    }

    public void showDescription()
    {
        UIDes.SetActive(true);
    }

   public  void ResetSelection()
    {
        descripcion.ResetDescription();
        DeselectAllItems();
    }

    private void DeselectAllItems()
    {
        foreach (inventarioItem item in listaDeItems)
        {
            item.Deselect();
        }
    }

    public void Hide()
       {
        UIDes.SetActive(false);
       
       }
    // Start is called before the first frame update
    void Start()
    {
        cierre.onClick.AddListener(Hide);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
