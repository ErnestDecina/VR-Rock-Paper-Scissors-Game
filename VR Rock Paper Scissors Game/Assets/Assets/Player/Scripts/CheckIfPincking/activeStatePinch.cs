using Oculus.Interaction;
using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class activeStatePinch : MonoBehaviour, IActiveState
{
    public OVRHand hand;  

    private float timePinched;
    private float downTime, upTime, pressTime = 0;
    private bool ready = false;
    private bool activeState = false;
    private float countDown = 1.45f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hand.GetFingerIsPinching(OVRHand.HandFinger.Index) && ready == false)
        {
            downTime = Time.time;
            pressTime = downTime + countDown;
            ready = true;
            activeState = false;
        }
        if (!hand.GetFingerIsPinching(OVRHand.HandFinger.Index))
        {
            ready = false;
            activeState = false;
            pressTime = 0;
        }
        if (Time.time >= pressTime && ready == true)
        {
            ready = false;
            activeState = true;
            pressTime = 0;
        }
    }
    public bool Active
    {
        get { return activeState; }
    }
}
