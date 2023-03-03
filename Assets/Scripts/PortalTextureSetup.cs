using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public Material camera1MAT;
    public Material camera2MAT;

    void Start()
    {
        if (camera1.targetTexture != null)
        {
            camera1.targetTexture.Release();
        }    
        camera1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera1MAT.mainTexture = camera1.targetTexture;
        
        if (camera2.targetTexture != null)
        {
            camera2.targetTexture.Release();
        }    
        camera2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera2MAT.mainTexture = camera2.targetTexture;
    }
}
