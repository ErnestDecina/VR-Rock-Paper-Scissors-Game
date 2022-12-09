using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Player")]
public class playerProperties : ScriptableObject
{
    // Vairables
    public string handPoseValue;

    // Set Values
    public void setLeftHandPose(string setLeftHandPoseValue)
    {
        handPoseValue = setLeftHandPoseValue;
    }

    public void setRightHandPose(string setRightHandPoseValue)
    {
        handPoseValue = setRightHandPoseValue;
    }

    // Return Values
    public string getHandPoseValue()
    {
        return handPoseValue;
    }

}
