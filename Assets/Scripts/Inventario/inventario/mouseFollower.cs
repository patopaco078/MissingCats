using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI    ;

public class mouseFollower : MonoBehaviour
{

    [SerializeField] Canvas canvas;
    [SerializeField] Camera cam;
    private inventarioItem item;


    public void Awake()
    {
        canvas = transform.root.GetComponent<Canvas>();
        cam = Camera.main;
        item = GetComponentInChildren<inventarioItem>();
    }

    public void SetData(Sprite sprite)
    {
        item.setData(sprite);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posicion;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, Input.mousePosition, canvas.worldCamera, out posicion);
        transform.position = canvas.transform.TransformPoint(posicion);
    }

    public void Toggle(bool val)
    {
        Debug.Log($"Item toggle{val}");
        gameObject.SetActive(val);

    }
}
