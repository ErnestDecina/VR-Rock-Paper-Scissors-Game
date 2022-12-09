using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changeText : MonoBehaviour
{
    public TextMeshProUGUI textHandPoseMessage;
    public playerProperties handPoseValue;

    // Start is called before the first frame update
    void Start()
    {
        textHandPoseMessage.text = "Hand Pose:\n?";
    }

    // Update is called once per frame
    void Update()
    {
        textHandPoseMessage.text = $"Hand Pose:\n{handPoseValue.getHandPoseValue()}";
    }
}
