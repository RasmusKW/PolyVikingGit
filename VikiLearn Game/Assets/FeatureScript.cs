using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeatureScript : MonoBehaviour {

   
   //------------buttons
   public Button BeardButton;
   public Button SkinButton;
   public Button HairButton;

    //---------------------IDK
    //public GameObject myObject; //for future work - Karo

    void Start()
    {
        SkinButton.gameObject.SetActive(true); //at default you can change Skin color
        BeardButton.gameObject.SetActive(false);
        HairButton.gameObject.SetActive(false);  
    }

    public void SkinClicked()
    {
        SkinButton.gameObject.SetActive(true); 
        BeardButton.gameObject.SetActive(false);
        HairButton.gameObject.SetActive(false);
    }

    public void BeardClicked()
    {
        SkinButton.gameObject.SetActive(false);
        BeardButton.gameObject.SetActive(true);
        HairButton.gameObject.SetActive(false);
    }

    public void HairClicked()
    {
        SkinButton.gameObject.SetActive(false);
        BeardButton.gameObject.SetActive(false);
        HairButton.gameObject.SetActive(true);
    }

}
