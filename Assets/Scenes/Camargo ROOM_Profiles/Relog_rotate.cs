using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Relog_rotate : MonoBehaviour
{
    public void RotateRelog()
    {
        gameObject.GetComponent<Transform>().DORotate(new Vector3(0, 130, 0), 1);
    }
}
