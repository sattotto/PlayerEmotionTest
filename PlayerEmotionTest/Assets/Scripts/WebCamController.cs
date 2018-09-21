using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCamController : MonoBehaviour {

	public int Width = 640;
    public int Height = 480;
    public int FPS = 30;

    void Start () {
        WebCamDevice[] devices = WebCamTexture.devices;
        // display all cameras
        for (var i = 0; i < devices.Length; i++) {
            Debug.Log (devices [i].name);
        }

        WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        GetComponent<Renderer> ().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

}
