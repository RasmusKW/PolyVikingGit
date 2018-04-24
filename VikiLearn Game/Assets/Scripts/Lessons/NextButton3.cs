using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton3 : MonoBehaviour {
    public Button Lesson1Page3, Lesson1Page4;
    public Button nextButtonThree, nextButtonFour;

    // Use this for initialization
    void Start()
    {
        Lesson1Page4.gameObject.SetActive(false);
        nextButtonFour.gameObject.SetActive(false);

    }


    public void NextButtonPress3()
    {
        // True
        Lesson1Page4.gameObject.SetActive(true);
        nextButtonFour.gameObject.SetActive(true);


        // False
        Lesson1Page3.gameObject.SetActive(false);
        nextButtonThree.gameObject.SetActive(false);




    }
}

