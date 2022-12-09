using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class userInterfaceToggle : MonoBehaviour
{
    public GameObject[] userInterface;
    public GameObject leftHand;
    private bool toggleState;

    // Start is called before the first frame update
    void Start()
    {
        toggleState = false;
    }

    public void toggleUI()
    {
        // Toggle Statement
        if (toggleState)
        {
            toggleState = false;
            for(int i = 0; i < userInterface.Length; i++)
                userInterface[i].SetActive(false);
        }
        else
        {
            toggleState = true;
            userInterface[0].SetActive(true);
        }
    }
}
