using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class debug : MonoBehaviour
{
    public float timeRemaining = 24;
    public playerProperties handPoseValue;
    public gameProperties coundownGameProperties;
    public AudioSource audio;
    public TextMeshProUGUI textOverlay;



    private string rockDeclaration = "";
    private string pose = "";
    private bool audioState = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        if (coundownGameProperties.getGameStart())
        {
            // Check Time Intervals
            // Range: 5 <-> 3 seconds
            if (timeRemaining <= 24 && timeRemaining > 12)
            {
                rockDeclaration = "Ready";
                if (coundownGameProperties.getIsCollide() == false) // || rightHandPose.getRightHandPose() != "Rock")
                {
                    textOverlay.text = $"Failed Count Down";
                    coundownGameProperties.falseGameStart();
                    audio.Stop();
                    return;
                }

            }
            // Range:
            // Jan
            else if (timeRemaining <= 12 && timeRemaining > 12.4)
            {
                rockDeclaration = "Jan";
                if (coundownGameProperties.getIsCollide() == false) // || rightHandPose.getRightHandPose() != "Rock")
                {
                    textOverlay.text = $"Failed Count Down";
                    coundownGameProperties.falseGameStart();
                    audio.Stop();
                    return;
                }

            }
            // Range:
            // Ken
            else if(timeRemaining <= 12.4 && timeRemaining > 12.3)
            {
                rockDeclaration = "Ken";

            }
            else if(timeRemaining <= 12.3 && timeRemaining > 1.65)
            {
                if (coundownGameProperties.getIsCollide() == true)
                {
                    textOverlay.text = $"Failed Count Downd";
                    coundownGameProperties.falseGameStart();
                    audio.Stop();
                    return;
                }
            }


            // Range: 
            // Pon
            else if (timeRemaining <= 1.4 && timeRemaining > 1.3)
            {
                rockDeclaration = "Pon";
            } // End if
            else if(timeRemaining <= 1.3 && timeRemaining > 1)
            {
                if (coundownGameProperties.getIsCollide() == false)
                {
                    textOverlay.text = $"Failed Count Down";
                    coundownGameProperties.falseGameStart();
                    audio.Stop();
                    return;
                }

                pose = handPoseValue.getHandPoseValue();
            }

            // Finish Count Down
            else if (timeRemaining <= 1)
            {
                // End The Game
                coundownGameProperties.falseGameStart();
                coundownGameProperties.trueWinStatus();

                // Display Results
                textOverlay.text = $"Pose:\n{pose}";

                // Reset
                resetValues();

                // Stop Function Call
                return;
            }

            // Decrease Time
            timeRemaining -= Time.deltaTime;
            textOverlay.text = $"Count Down:\n{timeRemaining}\n{rockDeclaration}";

        }
        // Reset Values
        else
        {
            resetValues();
        }
    }

    private void resetValues()
    {
        timeRemaining = 24;
        rockDeclaration = "";
        pose = "";
        audioState = false;
    }
}
