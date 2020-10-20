using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour {

    public Material[] PlayerColorMat;
    Material CurrMat;
    new  Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    //render blue color
    public void YellowColor()
    {
        renderer.material = PlayerColorMat[0];
        CurrMat = renderer.material;
    }

    //render red color
    public void RedColor()
    {
        renderer.material = PlayerColorMat[1];
        CurrMat = renderer.material;
    }

    //render greencolor
    public void GreenColor(){
         renderer.material = PlayerColorMat[2];
        CurrMat = renderer.material;
    }

    //render yellow color

    public void BlueColor()
    {
        renderer.material = PlayerColorMat[3];
        CurrMat = renderer.material;
    }


   
}

