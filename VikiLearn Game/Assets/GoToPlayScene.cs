using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlayScene : MonoBehaviour {

    public void goNextScene()
    {
        SceneManager.LoadScene("DitteVersion");
    }

    public void goBack()
    {
        SceneManager.LoadScene("FrontPage");
    }
}
