using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformHora : MonoBehaviour
{
    [SerializeField]
    KeyCode cambioHora;
    [SerializeField]
    float hcorrecta;

    float counter = 30f;
    bool gano = false;

    // Start is called before the first frame update
    void Start()
    {
    }
 // Update is called once per frame
    void Update()
    {
        //var q = Quaternion.AngleAxis(24, vector3.left);
        if (Input.GetKeyDown(cambioHora) )
        {
            GetComponent<Rigidbody>().rotation = Quaternion.Euler( 0f, 0f, counter);
            counter += 30f;
            //Debug.Log(counter);
        }

        if(GetComponent<Rigidbody>().rotation == Quaternion.Euler(0f,0f, hcorrecta) && gano==false)
        {
            Debug.Log("posicion correcta");
            gano = true;
        }


       
    }
    public void MoveHour()
    {
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0f, 0f, counter);
        counter += 30f;

    }
}
