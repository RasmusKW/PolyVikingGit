using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HairChange : MonoBehaviour {

    public Sprite man1Image;
    public Sprite man2Image;
    public Sprite man3Image;
    private Sprite[] manArray = new Sprite[3];
    public GameObject characterImage;

    // private SpriteRenderer spriteRenderer;

    private void Start()
    {
        manArray[0] = man1Image;
        manArray[1] = man2Image;
        manArray[2] = man3Image;
    }



    public void changeHairRight()
    {
        Debug.Log("changeto hairRight function clicked");


        characterImage.GetComponent<Image>().overrideSprite = man3Image;
    }

}
