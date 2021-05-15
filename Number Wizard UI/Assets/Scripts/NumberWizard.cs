using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializedField] int max;
    [SerializedField] int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max=max+1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min=guess;
            NextGuess();
            
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max=guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Oh! So that's your number, "+guess+"!!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min+max)/2;
        Debug.Log("Your number greater or lower than " + guess);
    }
}
