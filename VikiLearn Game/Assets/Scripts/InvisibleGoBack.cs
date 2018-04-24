using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvisibleGoBack : MonoBehaviour {

    public Button Lesson, Quiz, LessonsToTake, Lesson1, Lesson2, Lesson3, Lesson4;
    public Button Lesson1Page1, Lesson1Page2, Lesson1Page3, Lesson1Page4, Lesson1PageFinish;
    public Button nextB1, nextButtonTwo, nextButtonThree, nextButtonFour, nextButtonFive;
    public Button QuizToTake, Quiz1, Quiz2, Quiz3, Quiz4;
    public Button Quiz1Page1, Q1option1, Q1option2, Q1option3;
    public Button Quiz1Page2, Q1P2Option1, Q1P2Option2, Q1P2Option3;
    public Button Quiz1PageThree, Q1Page3option1, Q1Page3option2, Q1Page3option3;
    public Button Quiz1Page4, Q1P4Option1, Q1P4Option2, Q1P4Option3;
    public Button Quiz1Finish, storeButtonQ1;
    public Button Q1Plank1, Q1Plank3;

    // Use this for initialization

    public void PressOutsideButtons()
    {
        Lesson.gameObject.SetActive(false);
        Quiz.gameObject.SetActive(false);

        // Lessons
        LessonsToTake.gameObject.SetActive(false);
        Lesson1.gameObject.SetActive(false);
        Lesson2.gameObject.SetActive(false);
        Lesson3.gameObject.SetActive(false);
        Lesson4.gameObject.SetActive(false);

        // Lesson 1
        Lesson1Page1.gameObject.SetActive(false);
        Lesson1Page2.gameObject.SetActive(false);
        Lesson1Page3.gameObject.SetActive(false);
        Lesson1Page4.gameObject.SetActive(false);
        Lesson1PageFinish.gameObject.SetActive(false);

        // Next buttons 
        nextB1.gameObject.SetActive(false);
        nextButtonTwo.gameObject.SetActive(false);
        nextButtonThree.gameObject.SetActive(false);
        nextButtonFour.gameObject.SetActive(false);
        nextButtonFive.gameObject.SetActive(false);

        // Quiz
        QuizToTake.gameObject.SetActive(false);
        Quiz1.gameObject.SetActive(false);
        Quiz2.gameObject.SetActive(false);
        Quiz3.gameObject.SetActive(false);
        Quiz4.gameObject.SetActive(false);

        // Quiz 1 page 1
        Quiz1Page1.gameObject.SetActive(false);
        Q1option1.gameObject.SetActive(false);
        Q1option2.gameObject.SetActive(false);
        Q1option3.gameObject.SetActive(false);

        // Quiz 1 page 2
        Quiz1Page2.gameObject.SetActive(false);
        Q1P2Option1.gameObject.SetActive(false);
        Q1P2Option2.gameObject.SetActive(false);
        Q1P2Option3.gameObject.SetActive(false);

        // Quiz page 3
        Quiz1PageThree.gameObject.SetActive(false);
        Q1Page3option1.gameObject.SetActive(false);
        Q1Page3option2.gameObject.SetActive(false);
        Q1Page3option3.gameObject.SetActive(false);

        // Quiz page 4
        Quiz1Page4.gameObject.SetActive(false);
        Q1P4Option1.gameObject.SetActive(false);
        Q1P4Option2.gameObject.SetActive(false);
        Q1P4Option3.gameObject.SetActive(false);

        // Quiz 1 finish 
        Quiz1Finish.gameObject.SetActive(false);
        storeButtonQ1.gameObject.SetActive(false);

        // Quiz 1 store
        Q1Plank1.gameObject.SetActive(false);
        Q1Plank3.gameObject.SetActive(false);


    }

}
