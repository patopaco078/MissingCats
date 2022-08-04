using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RigMod : MonoBehaviour
{
    [SerializeField] Rig rigo;
    float counter;
    bool Down = false;

    private void Update()
    {
        if (Input.GetButton("Jump"))
        {
            Down = false;
            if (counter < 1)
            {
                counter += Time.deltaTime;
                rigo.weight = counter;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            Down = true;
        }

        if (Down)
        {
            if(counter > 0)
            {
                counter -= Time.deltaTime;
                rigo.weight = counter;
            }
        }
    }
}
