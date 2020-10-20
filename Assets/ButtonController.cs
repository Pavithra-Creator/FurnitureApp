namespace GoogleARCore.Examples.HelloAR
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using GoogleARCore;
    public class ButtonController : MonoBehaviour
    {
         GameObject controllerGO;
    GameObject controllerGO1;
       GameObject controllerGO2;
        SceneController scriptMyHelloAR;
        SceneCon script2;
        SceneController_Cy script3;
        public GameObject CubeGo;
        public GameObject SphereGo;
        public GameObject CylinderGO;
        // Use this for initialization
        public void ChangeObjectTypeTocube()
        {
            controllerGO = GameObject.Find("Controller");
            scriptMyHelloAR = controllerGO.GetComponent<SceneController>();
            //CubeGo = GameObject.Find("Cube");
            scriptMyHelloAR.ARAndroidPrefab = CubeGo;
            //button.onClick.AddListener(delegate { DeactiveObject(objectToDeactivate); });
        }



        public void ChangeObjectTypeToSphere()
        {
            controllerGO = GameObject.Find("sphereCon1");
            script2 = controllerGO1.GetComponent<SceneCon>();
            script2.ARAndroidPrefab = SphereGo;
        }

        public void ChangeObjectTypeToCylinder()
        {
            controllerGO = GameObject.Find("cyclinderCon");
            script3 = controllerGO2.GetComponent<SceneController_Cy>();
            script3.ARAndroidPrefab = CylinderGO;
        }

    }
}