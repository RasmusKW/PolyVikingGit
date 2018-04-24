using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenStoreQ1 : MonoBehaviour {

    public Button Quiz1Finish, storeButtonQ1;
    public Button Q1Plank1, Q1Plank3;

    // Use this for initialization
    void Start () {
        Q1Plank1.gameObject.SetActive(false);
        Q1Plank3.gameObject.SetActive(false);
		
	}
	
	public void StoreQuizOneOpen(){
        // True
        Q1Plank1.gameObject.SetActive(true);
        Q1Plank3.gameObject.SetActive(true);

        // False
        Quiz1Finish.gameObject.SetActive(false);
        storeButtonQ1.gameObject.SetActive(false);
    }
}
