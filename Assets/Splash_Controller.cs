using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash_Controller : MonoBehaviour {
    public float delayTime = 3;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(delayTime);
        Application.LoadLevel(1);
    }
}
