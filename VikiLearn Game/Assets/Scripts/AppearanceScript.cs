using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppearanceScript : MonoBehaviour {

    public SpriteRenderer part; 
    public Sprite[] options; //empty 'leading' array 
    public Sprite[] femaleOptions; //array with female characters
    public Sprite[] maleOptions; //array with male characters 
    public int index;


    //-----------------BEARD------------
    public SpriteRenderer beard;
    public Sprite[] beards;
    public int beard_index;

    
   /* //-------------------SKIN------
    public SpriteRenderer skin;
    public Sprite[] skins;
    public int skin_index;
    */

    //-------------------HAIR----------
    public SpriteRenderer hair;
    public Sprite[] hairs;
    public int hair_index;

   

    void Start()
    {  
        options = maleOptions;
    }


    void Update () {
		for(int i=0; i<options.Length; i++)
        {
            if (i == index)
                part.sprite = options[i];
        }
     
        //-----------for beard-----------
        for (int i = 0; i < beards.Length; i++)
        {
            if (i == beard_index)
                beard.sprite = beards[i];
        }
        /*
        //----------skin
        for (int i = 0; i < skins.Length; i++)
        {
            if (i == skin_index)
                skin.sprite = skins[i];
        }
        */

        //-----------hair
        for (int i = 0; i < hairs.Length; i++)
        {
            if (i == hair_index)
               hair.sprite = hairs[i];
        }
    }


    public void Swap()
    {
        if (index < options.Length - 1)
            index++;
        else
            index = 0;
    }

    public void ToWoman()
    {
        beard_index = 0; // no beard for WOMAN goddamit
        hair_index = 0;
        index = 0;
        Debug.Log("change to woman function clicked");
        options = femaleOptions;
    }

    public void ToMan()
    {
        //hat_index = 0; //prevents hat from, being visible
        Debug.Log("change to man function clicked");
        index = 0;
        options = maleOptions;
    }

    private int changeLoop(Sprite[] array, int sth_index)
    {
        if (sth_index < array.Length - 1)
            sth_index++;
        else
            sth_index = 0;

        return sth_index;
    }

    public void changeBeard()
    {
        if (options == maleOptions)
            beard_index=changeLoop(beards, beard_index);
    }

    /*
    public void changeSkin()
    {
        if (options == maleOptions)
            skin_index = changeLoop(skins, skin_index);
        if (options == femaleOptions)
            index = 0;
    }
    */

    public void changeHair()
    {
        if (options == maleOptions)
            hair_index = changeLoop(hairs, hair_index);
    }



}

