//Video.cs

// Starts the default camera and assigns the texture to the current renderer
using UnityEngine;
using System;

namespace VideoPlayback
{
	public class Webcam : MonoBehaviour 
	{
        void Start() {
            WebCamTexture webcamTexture = new WebCamTexture();
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }

        void Update() {

        }
    }
}