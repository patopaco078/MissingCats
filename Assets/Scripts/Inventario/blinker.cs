using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinker : MonoBehaviour
{
    private Color colorinicial = Color.white;
    private Color colorfinal = Color.red;
    [Range(0, 10)]
    public float velocidadColor=2.5f;
    Renderer sennal;
    // Start is called before the first frame update
    void Start()
    {
        sennal = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sennal.material.color = Color.Lerp(colorinicial, colorfinal, Mathf.PingPong(Time.time * velocidadColor, 1));
    }
}
