using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plank3Click : MonoBehaviour {
    public Button Q1Plank1, Q1Plank3;
    public GameObject planks3Building;
    public GameObject planks;

    // Use this for initialization
    void Start()
    {

        planks3Building.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClick3Plank()
    {
        // True
        planks3Building.gameObject.SetActive(true);

        // False
        Q1Plank1.gameObject.SetActive(false);
        Q1Plank3.gameObject.SetActive(false);
        planks.gameObject.SetActive(false);
    }
}
