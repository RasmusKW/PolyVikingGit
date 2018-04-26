using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenQuiz : MonoBehaviour {

    public Button Lesson, Quiz, Lesson1PageFinish, nextButtonFive, QuizToTake, Quiz1, Quiz2, Quiz3, Quiz4;


    // Use this for initialization
    void Start () {

        QuizToTake.gameObject.SetActive(false);
        Quiz1.gameObject.SetActive(false);
        Quiz2.gameObject.SetActive(false);
        Quiz3.gameObject.SetActive(false);
        Quiz4.gameObject.SetActive(false);

    }


    public void OpenQuizPage() {

        // True
        QuizToTake.gameObject.SetActive(true);
        Quiz1.gameObject.SetActive(true);
        Quiz2.gameObject.SetActive(true);
        Quiz3.gameObject.SetActive(true);
        Quiz4.gameObject.SetActive(true);

        // False
        Lesson.gameObject.SetActive(false);
        Quiz.gameObject.SetActive(false);

        Lesson1PageFinish.gameObject.SetActive(false);
        nextButtonFive.gameObject.SetActive(false);
    }
    
    
}
