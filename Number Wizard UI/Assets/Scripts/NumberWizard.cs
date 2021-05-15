using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if (min==1000)
        {
            NextGuess();
        }
        else
        {
            min=guess+1;
            NextGuess();
        }
        
    }
    public void OnPressLower()
    {
        max=guess-1;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }
}
