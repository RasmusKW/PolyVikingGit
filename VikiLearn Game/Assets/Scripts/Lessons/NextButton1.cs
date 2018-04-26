using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton1 : MonoBehaviour {
    public Button Lesson1Page1, Lesson1Page2;
    public Button nextB1, nextButtonTwo;

    // Use this for initialization
    void Start()
    {
        Lesson1Page2.gameObject.SetActive(false);
       
        // Next buttons 
        nextButtonTwo.gameObject.SetActive(false);

    }


    public void NextButtonPress()
    {
        // True
        Lesson1Page2.gameObject.SetActive(true);
        nextButtonTwo.gameObject.SetActive(true);

        // False
        Lesson1Page1.gameObject.SetActive(false);
        nextB1.gameObject.SetActive(false);

    }
}
