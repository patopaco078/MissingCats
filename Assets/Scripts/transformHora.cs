using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class transformHora : MonoBehaviour
{
    [SerializeField] private UnityEvent doThis;

    [SerializeField]
    KeyCode cambioHora;
    [SerializeField]
    float hcorrecta;

    float counter = -30f;
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
            GetComponent<Rigidbody>().rotation = Quaternion.Euler(counter, 0f, 0f);
            counter += 30f;
            //Debug.Log(counter);
        }

        if(GetComponent<Rigidbody>().rotation == Quaternion.Euler(hcorrecta,0f, 0f ) && gano==false)
        {
            Debug.Log("posicion correcta");
            gano = true;
            doThis.Invoke();
        }


       
    }
    public void MoveHour()
    {
        GetComponent<Rigidbody>().rotation = Quaternion.Euler( counter,0f, 0f );
        counter -= 30f;

    }
}
