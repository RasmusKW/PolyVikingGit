using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz1NextPage2 : MonoBehaviour {

    public Button Quiz1Page2, Q1P2Option1, Q1P2Option2, Q1P2Option3;
    public Button Quiz1Page1, Q1option1, Q1option2, Q1option3;
    public Button QuizToTake, Quiz1, Quiz2, Quiz3, Quiz4;

    // Use this for initialization
    void Start () {

        Quiz1Page2.gameObject.SetActive(false);
        Q1P2Option1.gameObject.SetActive(false);
        Q1P2Option2.gameObject.SetActive(false);
        Q1P2Option3.gameObject.SetActive(false);

    }
	
	public void SecondPageQuiz()
    {
        // True
        Quiz1Page2.gameObject.SetActive(true);
        Q1P2Option1.gameObject.SetActive(true);
        Q1P2Option2.gameObject.SetActive(true);
        Q1P2Option3.gameObject.SetActive(true);

        // False
        Quiz1Page1.gameObject.SetActive(false);
        Q1option1.gameObject.SetActive(false);
        Q1option2.gameObject.SetActive(false);
        Q1option3.gameObject.SetActive(false);

        // False
        QuizToTake.gameObject.SetActive(false);
        Quiz1.gameObject.SetActive(false);
        Quiz2.gameObject.SetActive(false);
        Quiz3.gameObject.SetActive(false);
        Quiz4.gameObject.SetActive(false);

    }
}
