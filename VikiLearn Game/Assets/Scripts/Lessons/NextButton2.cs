using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton2 : MonoBehaviour {
    public Button Lesson1Page2, Lesson1Page3;
    public Button nextButtonTwo, nextButtonThree;

    // Use this for initialization
    void Start()
    {
        Lesson1Page3.gameObject.SetActive(false);

        // Next buttons 
        nextButtonThree.gameObject.SetActive(false);

    }


    public void ButtonPress2()
    {
        // True
        Lesson1Page3.gameObject.SetActive(true);
        nextButtonThree.gameObject.SetActive(true);

        // False
        Lesson1Page2.gameObject.SetActive(false);
        nextButtonTwo.gameObject.SetActive(false);

      

    }
}
