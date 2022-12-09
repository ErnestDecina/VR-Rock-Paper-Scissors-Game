using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Enviroment/Skybox/ChangeSkybox")]
public class changeSkybox : ScriptableObject
{
    public Material materialSkyBoxBlink;
    public Material materialSkyBoxOpenEyes;

    public void blinkSkybox()
    {
        RenderSettings.skybox = materialSkyBoxBlink;
    }

    public void unblinkSkybox()
    {
        RenderSettings.skybox = materialSkyBoxOpenEyes;
    }
}
