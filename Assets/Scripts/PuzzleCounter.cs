using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuzzleCounter : MonoBehaviour
{

    public TextMeshProUGUI puzzleCounter;

    public int counter;
    private void Start()
    {
        puzzleCounter.text = counter.ToString() + "/3";
        counter = 0;
    }
    void update()
    {

       
    }

    // Update is called once per frame
    public void PuzzleDone ()
    {
        counter++;
        puzzleCounter.text = counter.ToString() + "/3";
    }
}
