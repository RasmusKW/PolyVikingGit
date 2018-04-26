using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q1FINISH : MonoBehaviour {

    public Button Quiz1Page4, Q1P4Option1, Q1P4Option2, Q1P4Option3;
    public Button Quiz1Finish, storeButtonQ1;

    // Use this for initialization
    void Start () {
        Quiz1Finish.gameObject.SetActive(false);
        storeButtonQ1.gameObject.SetActive(false);
	}
	
	public void QuizOneFinish()
    {
     // True
        Quiz1Finish.gameObject.SetActive(true);
        storeButtonQ1.gameObject.SetActive(true);
    
    // False
        Quiz1Page4.gameObject.SetActive(false);
        Q1P4Option1.gameObject.SetActive(false);
        Q1P4Option2.gameObject.SetActive(false);
        Q1P4Option3.gameObject.SetActive(false);
    }
}
