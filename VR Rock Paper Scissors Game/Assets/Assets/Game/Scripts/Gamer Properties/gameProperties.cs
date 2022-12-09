using UnityEngine;

[CreateAssetMenu(fileName = "CountdownProperties", menuName = "ScriptableObjects/Game/CountdownProperties")]
public class gameProperties : ScriptableObject
{
    // Variables
    private uint startProcessCount = 0;
    private bool isCollide = false;
    private bool gameStarted = false;
    private bool winStatus = false;
    private bool audioState = false;
    
    public void trueIsCollide()
    {
        isCollide = true;
    }

    public void falseIsCollide()
    {
        isCollide = false;
    }

    public bool getIsCollide()
    {
        return isCollide;
    }

    public void trueWinStatus()
    {
        winStatus = true;
    }

    public void falseWinStatus()
    {
        winStatus = false;
    }

    public bool getWinStatus()
    {
        return winStatus;
    }

    public void trueGameStart()
    {
        gameStarted = true;
    }

    public void falseGameStart()
    {
        gameStarted = false;
    }

    public bool getGameStart()
    {
        return gameStarted;
    }

    public void trueAudioState()
    {
        audioState = true;  
    }

    public void falseAudioState()
    {
        audioState = false;
    }

    public bool getAudioState()
    {
        return audioState;
    }
}
