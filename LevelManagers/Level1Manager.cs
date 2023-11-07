using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
{
    public GameObject bob;

    private bool isLevelComplete = false;

    private void Start() {
        PlayerPrefs.SetInt("Level1Completed", 0);
    }
    private void Update()
    {
        if(bob != null && bob.transform.position.x >= 20 && !isLevelComplete) {
            LevelComplete();
            isLevelComplete = true;
        }
    }
    private void LevelComplete() {
            PlayerPrefs.SetInt("Level1Completed", 1);
            LoadScreen();
    }

    private void LoadScreen() {
        StartCoroutine(LoadSceneWithDelay());
    }
    private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Levels");
    }

}
