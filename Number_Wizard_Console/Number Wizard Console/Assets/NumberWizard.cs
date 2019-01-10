using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max, min, guess;

    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
        Debug.Log("Welcome to NumberWizard");
        Debug.Log("The max you can pick is" + max);
        Debug.Log("The min you can pick is" + min);
        Debug.Log("My first guess is" + guess);
    }

    void guessNext()
    {
        guess = (min + max) / 2;
        Debug.Log("The next guess is" + guess);
    }


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guessNext();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guessNext();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You got it");
        }
    }

}
