using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q1P3 : MonoBehaviour {

    public Button Quiz1Page2, Q1P2Option1, Q1P2Option2, Q1P2Option3;
    public Button Quiz1PageThree, Q1Page3option1, Q1Page3option2, Q1Page3option3;

    // Use this for initialization
    void Start()
    {
        Quiz1PageThree.gameObject.SetActive(false);
        Q1Page3option1.gameObject.SetActive(false);
        Q1Page3option2.gameObject.SetActive(false);
        Q1Page3option3.gameObject.SetActive(false);
    }

    public void ThirdPageQuiz()
    {
        // True
        Quiz1PageThree.gameObject.SetActive(true);
        Q1Page3option1.gameObject.SetActive(true);
        Q1Page3option2.gameObject.SetActive(true);
        Q1Page3option3.gameObject.SetActive(true);


        // False
        Quiz1Page2.gameObject.SetActive(false);
        Q1P2Option1.gameObject.SetActive(false);
        Q1P2Option2.gameObject.SetActive(false);
        Q1P2Option3.gameObject.SetActive(false);
    }
}

