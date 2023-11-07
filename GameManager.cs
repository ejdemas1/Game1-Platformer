using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Image = UnityEngine.UI.Image;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public ButtonManager levelButtonManager;

    private void Start() {
        int Level1Completed = PlayerPrefs.GetInt("Level1Completed", 0);
        if (Level1Completed == 1) {
            //Unlock Level 2
            levelButtonManager.UnlockLevelButton(1);
        }
        int Level2Completed = PlayerPrefs.GetInt("Level2Completed", 0);
        if (Level2Completed == 1) {
            //Unlock Level 3
            levelButtonManager.UnlockLevelButton(2);
        }
        int Level3Completed = PlayerPrefs.GetInt("Level3Completed", 0);
        if (Level3Completed == 1) {
            //Unlock Level 4
            levelButtonManager.UnlockLevelButton(3);
        }
    }

    public void OnLevelComplete(int levelNumber)
    {
        Debug.Log("Level " + levelNumber + " Completed");
        if (levelNumber != 5) {
            Unlock(levelNumber + 1);
        } else {
            LoadScreen();
        }

    }

    public void Unlock(int levelNumber) {
        Debug.Log($"Unlock {levelNumber}");
        levelButtonManager.UnlockLevelButton(levelNumber);
    }

     private void LoadScreen() {
        StartCoroutine(LoadSceneWithDelay());
    }
    private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
