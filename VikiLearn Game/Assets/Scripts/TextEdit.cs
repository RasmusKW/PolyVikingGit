using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEdit : MonoBehaviour
{

    public Text MyText;
    public UserData userData;
    public string userName;
    //public string welcome = "Welcome";



    // Update is called once per frame
    void Start()
    {
        userData = FindObjectOfType<UserData>();
        userName = userData.GetName();
        MyText.text = "WELCOME " + userName + "!";
    }
}

