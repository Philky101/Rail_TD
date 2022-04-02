using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject cameraTopNorth; //Top Down, North is up.
    public GameObject cameraTopWest; ////Top Down, West is up.
    public GameObject cameraTopSouth; //Top Down, South is up.
    public GameObject cameraTopEast; //Top Down, East is up.
    public GameObject cameraIsoNorth; //Isometric view, North is up.
    public GameObject cameraIsoWest; //Isometric view, West is up.
    public GameObject cameraIsoSouth; //Isometric view, South is up.
    public GameObject cameraIsoEast;  //Isometric view, East is up.

    private GameObject[,] cameraArray = new GameObject[2,4];
    private int i = 1; //Tracks main camera's vertical position
    private int j = 0; //Tracks main camera's horizontal position
    private GameObject mainCamera;


    /*void Start()
    {
        cameraArray[0, 0] = cameraIsoNorth; //cameraArray[0, 1] = cameraIsoWest; cameraArray[0, 2] = cameraIsoSouth; cameraArray[0, 3] = cameraIsoEast;
        cameraArray[1, 0] = cameraTopNorth; //cameraArray[1, 1] = cameraTopWest; cameraArray[1, 2] = cameraTopSouth; cameraArray[1, 3] = cameraTopEast;
        mainCamera = cameraArray[i, j];
        Debug.Log(cameraArray[0, 0]);
    }

    private void setMainCamera(GameObject newMain)
    {
        mainCamera.tag = "Auxilliary Camera"; //Turn old camera off
        mainCamera = newMain; //Select the main camera to the new camera
        mainCamera.tag = "Main Camera"; //Turn the new camera on
    }*/

    public void switchCam()
    {
        cameraTopNorth.tag = "Auxilliary Camera";
        cameraIsoNorth.tag = "MainCamera";
    }

    public void moveCameraUp()
    {
        
    }
}
