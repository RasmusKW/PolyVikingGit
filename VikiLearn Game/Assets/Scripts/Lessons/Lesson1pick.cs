using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson1pick : MonoBehaviour {

    public Button LessonsToTake, Lesson1, Lesson2, Lesson3, Lesson4;
    public Button Lesson1Page1, Lesson1Page2;
    public Button nextB1;

    // Use this for initialization
    void Start()
    {
        // Lesson 1
        Lesson1Page1.gameObject.SetActive(false);
        nextB1.gameObject.SetActive(false);

    }


    public void OpenLesson1()
    {
        // True
        Lesson1Page1.gameObject.SetActive(true);
        nextB1.gameObject.SetActive(true);

        // False
        LessonsToTake.gameObject.SetActive(false);
        Lesson1.gameObject.SetActive(false);
        Lesson2.gameObject.SetActive(false);
        Lesson3.gameObject.SetActive(false);
        Lesson4.gameObject.SetActive(false);

    }
}
