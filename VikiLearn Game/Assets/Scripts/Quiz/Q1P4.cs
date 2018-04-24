using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Q1P4 : MonoBehaviour {

    public Button Quiz1Page4, Q1P4Option1, Q1P4Option2, Q1P4Option3;
    public Button Quiz1PageThree, Q1Page3option1, Q1Page3option2, Q1Page3option3;


    // Use this for initialization
    void Start () {
        Quiz1Page4.gameObject.SetActive(false);
        Q1P4Option1.gameObject.SetActive(false);
        Q1P4Option2.gameObject.SetActive(false);
        Q1P4Option3.gameObject.SetActive(false);
    }
	
public void FourthPageQuiz1()
    {
        // True
        Quiz1Page4.gameObject.SetActive(true);
        Q1P4Option1.gameObject.SetActive(true);
        Q1P4Option2.gameObject.SetActive(true);
        Q1P4Option3.gameObject.SetActive(true);

        // False
        Quiz1PageThree.gameObject.SetActive(false);
        Q1Page3option1.gameObject.SetActive(false);
        Q1Page3option2.gameObject.SetActive(false);
        Q1Page3option3.gameObject.SetActive(false);
    }
}
