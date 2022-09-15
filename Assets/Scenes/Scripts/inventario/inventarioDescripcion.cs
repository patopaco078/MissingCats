using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inventarioDescripcion : MonoBehaviour
{

    [SerializeField] public Image ItemImagen;
    [SerializeField] public Image ItemImagenDescrpcion;
    [SerializeField] public TMP_Text titulo;
    [SerializeField] public TMP_Text descripcion;

    public void Awake()
    {
        ResetDescription();
    }

    public void ResetDescription()
    {
        this.ItemImagen.gameObject.SetActive(false);
        this.titulo.text = "";
        this.descripcion.text = "";

    }

    public void SetDescription(bool condicion,Sprite sprite, Sprite ImagenDescripcion, string nombreItem, string descripcionItem)
    {
        
        this.ItemImagen.gameObject.SetActive(true);
        this.ItemImagen.sprite = sprite;
        this.titulo.text = nombreItem;
        this.descripcion.text = descripcionItem;
        this.ItemImagenDescrpcion.sprite = ImagenDescripcion;
        if (condicion == true)
        {
            ItemImagenDescrpcion.gameObject.SetActive(true);
            titulo.gameObject.SetActive(false);
            descripcion.gameObject.SetActive(false);
        }
        else
        {
            ItemImagenDescrpcion.gameObject.SetActive(false);
            titulo.gameObject.SetActive(true);
            descripcion.gameObject.SetActive(true);

        }
    }

}
