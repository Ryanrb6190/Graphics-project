using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    public float RotateSpeed;

    void Start()
    {
        RenderSettings.skybox.SetFloat("_Rotation",0);
    }
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
