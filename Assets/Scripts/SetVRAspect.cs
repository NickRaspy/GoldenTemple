using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SetVRAspect : MonoBehaviour
{
    private void Awake()
    {
        XRSettings.eyeTextureResolutionScale = 2f;
    }
}
