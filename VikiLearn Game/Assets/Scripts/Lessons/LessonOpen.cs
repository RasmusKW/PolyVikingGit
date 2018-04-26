using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonOpen : MonoBehaviour {

    public Button Lesson, Quiz, LessonsToTake, Lesson1, Lesson2, Lesson3, Lesson4;   

    // Use this for initialization
    void Start () {

        // Lessons
        LessonsToTake.gameObject.SetActive(false);
        Lesson1.gameObject.SetActive(false);
        Lesson2.gameObject.SetActive(false);
        Lesson3.gameObject.SetActive(false);
        Lesson4.gameObject.SetActive(false);
        

    }
	

    public void OpenLessonsOnClick()
    {
        // True
        LessonsToTake.gameObject.SetActive(true);
        Lesson1.gameObject.SetActive(true);
        Lesson2.gameObject.SetActive(true);
        Lesson3.gameObject.SetActive(true);
        Lesson4.gameObject.SetActive(true);

        // False
        Lesson.gameObject.SetActive(false);
        Quiz.gameObject.SetActive(false);
       
    }

}
