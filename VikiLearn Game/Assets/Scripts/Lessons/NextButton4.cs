using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton4 : MonoBehaviour {

    public Button Lesson1PageFinish, Lesson1Page4;
    public Button nextButtonFive, nextButtonFour;

    // Use this for initialization
    void Start()
    {
        Lesson1PageFinish.gameObject.SetActive(false);
        nextButtonFive.gameObject.SetActive(false); // The take quiz button

    }


    public void NextButtonPress4()
    {
        // True
        Lesson1PageFinish.gameObject.SetActive(true);
        nextButtonFive.gameObject.SetActive(true);


        // False
        Lesson1Page4.gameObject.SetActive(false);
        nextButtonFour.gameObject.SetActive(false);

    }
}
