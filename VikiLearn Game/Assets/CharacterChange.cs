using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterChange : MonoBehaviour {

    public Sprite womanImage;
  //  public Sprite manImage;
    public GameObject characterImage;

    private Sprite temp;
    public Sprite man1Image;
    public Sprite man2Image;
    public Sprite man3Image;
    private Sprite[] manArray = new Sprite[3];

    // private SpriteRenderer spriteRenderer;

    private void Start()
    {
        manArray[0] = man1Image;
        manArray[1] = man2Image;
        manArray[2] = man3Image;

        characterImage.GetComponent<Image>().overrideSprite = manArray[0];

        //  characterImage = GameObject.Find("characterimage"); // You can find that refference in any way you want, its just example.
    }

   public void changeToMan () {
        Debug.Log("change to man function clicked");
        characterImage.GetComponent<Image>().overrideSprite = manArray[0];
    }

   public void changeToWoman()
    {
        Debug.Log("change to woman function clicked");
        characterImage.GetComponent<Image>().overrideSprite = womanImage;
    }

    public void hairArrow()
    {
        Debug.Log("change HAIR arrow clicked");

        for (int i = 0; i < manArray.Length; i++)
        {
            if (characterImage.GetComponent<Image>().sprite == manArray[0])
                characterImage.GetComponent<Image>().overrideSprite = manArray[1]; 

            if (characterImage.GetComponent<Image>().sprite == manArray[1])
            {
                Debug.Log("i am in array[1]");
                characterImage.GetComponent<Image>().overrideSprite = manArray[2];
            }

          /*  if (characterImage.GetComponent<Image>().sprite == manArray[2])
                characterImage.GetComponent<Image>().overrideSprite = manArray[0];
               */ 
        }
    }

}
