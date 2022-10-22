using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PuzzleCounter : MonoBehaviour
{

    public TextMeshProUGUI puzzleCounter;
    [SerializeField] private string Nivel2;
    [SerializeField] private string Menu;
    [SerializeField] private UnityEvent doThis;

    public int counter;
    private bool firstTime = true;

    [SerializeField] private float timePassed = 0;
    private void Start()
    {
        puzzleCounter.text = counter.ToString() + "/3";
        counter = 0;
        timePassed = 0;
        firstTime = true;
    }
    void Update()
    {
        if (counter == 3)
        {
            if (firstTime == true)
            {
                doThis.Invoke();

                firstTime = false;
                StartCoroutine(LVLDone(5));
            }
            //if (timePassed > 5f)
            //{
            //    timePassed += Time.deltaTime;
            //}
            //else if (timePassed < 5f)
            //{
            //    SceneManager.LoadScene(Menu);
            //}
        }
    }

    // Update is called once per frame
    public void PuzzleDone ()
    {
        counter++;
        puzzleCounter.text = counter.ToString() + "/3";
    }

    IEnumerator LVLDone(int secs)
    {
        yield return new WaitForSeconds(secs);
        //SceneManager.LoadScene(Menu);
        SceneManager.LoadScene(Nivel2);
    }
}
