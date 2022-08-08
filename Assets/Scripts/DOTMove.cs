using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTMove : MonoBehaviour
{
    [SerializeField] private Transform[] propsTanforms;
    [SerializeField] private float time;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    void Start()
    {
        propsTanforms[0].DOMove(new Vector3(x, y, z), time).SetLoops(-1, LoopType.Yoyo);
        propsTanforms[1].DOMove(new Vector3(x, y, z), time).SetLoops(-1, LoopType.Yoyo);
    }

    private void OnTriggerEnter(Collider collider)
    {
        transform.DOMove(new Vector3(x, y, z), time);
    }

}
