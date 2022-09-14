using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class inventarioItem : MonoBehaviour
{
    // Start is called before the first frame update
 
 [SerializeField] private Image itemeImagen;
  [SerializeField] private Image marcoImagen;



  public event Action<inventarioItem> OnItemClicked, OnItemDroppedOn,OnItemBeginDrag,OnItemEndDrag, OnRightMouseBtnClick;

  private bool vacio=true;
    internal object item;

    public void Awake()
  {
    ResetData();
    Deselect();
  }

  public void ResetData()
  {
        this.itemeImagen.gameObject.SetActive(false);
        vacio =true;
  }

  public void Deselect()
  {
    marcoImagen.enabled=false;
  }

  public void setData(Sprite sprite)
  {
    this.itemeImagen.gameObject.SetActive(true);
    this.itemeImagen.sprite=sprite;
    vacio=false;
  }

  public void Select()
  {
    marcoImagen.enabled=true;
  }

  public void OnBeginDrag()
  {
    if(vacio)
    return;
        OnItemBeginDrag?.Invoke(this);
   

  }

  public void OnEndDrag()
  {
    OnItemEndDrag?.Invoke(this);
  }

  public void OnDrop()
  {
    OnItemDroppedOn?.Invoke(this);
  }
    public void prueba()
    {
        Debug.Log("prueba");
    }


public void OnPointerClick(BaseEventData data)
  {
        
        PointerEventData pointerdata=(PointerEventData)data;
    if(pointerdata.button==PointerEventData.InputButton.Right)
    {
        OnRightMouseBtnClick?.Invoke(this);

    }
    else{
        OnItemClicked?.Invoke(this);
    }
  }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
