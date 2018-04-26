using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickableScript : MonoBehaviour {

	public void goNextScene()
    {
        SceneManager.LoadScene("characterScene");
    }
}
