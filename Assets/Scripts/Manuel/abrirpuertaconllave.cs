using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirpuertaconllave : MonoBehaviour
{
    [SerializeField]
    private controlInventario inventario;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name.Equals("puerta"))
                {
                    for (int i = 0; i < inventario.inventarioData.inventarioItems.Count; i++)
                    {
                        if (inventario.inventarioData.inventarioItems[i].item != null)
                        {
                            if (inventario.inventarioData.inventarioItems[i].item.Name == "Llave")
                            {
                                inventario.inventarioData.inventarioItems.Remove(inventario.inventarioData.inventarioItems[i]);

                                this.GetComponent<Animator>().Play("Abrir");
                            
                                     
                                break;
                            }
                               
                               
                            }
                           
                        }
                        
                    }

                }

            }
        }
    }

