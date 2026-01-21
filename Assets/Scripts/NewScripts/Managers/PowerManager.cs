using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public bool isGreenSoulUnlocked { get; private set; }
    public bool isBlueSoulUnlocked {get; private set; }
    
    public void UnlockGreenSoul()
    {
        isGreenSoulUnlocked = true;
        Debug.Log("PowerManager script : Unlocked GreenSoul");
    }

    public void UnlockBlueSoul()
    {
        isBlueSoulUnlocked = true;
        Debug.Log("PowerManager script : Unlocked BlueSoul");
    }
}
