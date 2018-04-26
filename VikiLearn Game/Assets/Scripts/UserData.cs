using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour {

    private string uname;
    private string uemail;
    private string unationality;

    public void SetName(string name)
    {
        uname = name;
        Debug.Log("saved namee is " + uname);
    }

    public void SetEmail(string email)
    {
        uemail = email;
        Debug.Log("saved email is " + uemail);
    }

    public void SetNationality(string nationality)
    {
        unationality = nationality;
        Debug.Log("saved nationality is " + unationality);
    }

    public string GetName()
    {
        return uname;
    }

    public  string GetEmail()
    {
        return uemail;
    }

    public string GetNationality()
    {
        return unationality;
    }

}
