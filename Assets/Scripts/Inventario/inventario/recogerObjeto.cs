using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogerObjeto : MonoBehaviour
{
    public GameObject marco;

    [SerializeField] InventarioSO data;
    // Start is called before the first frame update
    void Start()
    {
        marco.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag.Equals("Recogido"))
                {
                    ItemPickeable itemI = hit.transform.GetComponent<ItemPickeable>();
                    data.AddItem(itemI.itemInventorio);
                    itemI.DestroyItem();
                }

                if (hit.transform.name.Equals("Cube (2)"))
                {
                    marco.SetActive(true);
                }

            }
        }
    }
}
