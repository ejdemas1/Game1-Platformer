using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialManager : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Level1Completed", 0);
        PlayerPrefs.SetInt("Level2Completed", 0);
        PlayerPrefs.SetInt("Level3Completed", 0);
        PlayerPrefs.SetInt("Level4Completed", 0);
        PlayerPrefs.SetInt("Level5Completed", 0);
    }

}
