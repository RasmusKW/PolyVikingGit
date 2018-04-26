using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    public Button Lesson, Quiz, LessonsToTake, Lesson1, Lesson2, Lesson3, Lesson4;
    public Button Lesson1Page1, Lesson1Page2, Lesson1Page3, Lesson1Page4, Lesson1PageFinish;
    public Button nextB1, nextButtonTwo, nextButtonThree, nextButtonFour, nextButtonFive;
    public Button QuizToTake, Quiz1, Quiz2, Quiz3, Quiz4;
    public Button invisibleButton;
    public Button Quiz1Page1, Q1option1, Q1option2, Q1option3;

    // Use this for initialization
    void Start ()
    {

        Lesson.gameObject.SetActive(false);
        Quiz.gameObject.SetActive(false);
        invisibleButton.gameObject.SetActive(false);

        // Lessons
        LessonsToTake.gameObject.SetActive(false);
        Lesson1.gameObject.SetActive(false);
        Lesson2.gameObject.SetActive(false);
        Lesson3.gameObject.SetActive(false);
        Lesson4.gameObject.SetActive(false);

        // Lesson 1
        Lesson1Page1.gameObject.SetActive(false);
        Lesson1Page2.gameObject.SetActive(false);

        // Next buttons 
        nextB1.gameObject.SetActive(false);
        nextButtonTwo.gameObject.SetActive(false);
       
    }

    public void DoStuffOnClick() // For the first button 
    {
        // True
        Lesson.gameObject.SetActive(true);
        Quiz.gameObject.SetActive(true);

        if (Lesson.gameObject == true && Quiz.gameObject == true)
        {
            invisibleButton.gameObject.SetActive(true);
        }


    }

}