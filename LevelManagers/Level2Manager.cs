using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Manager : MonoBehaviour
{
    public GameObject bob;

    public Sprite unlocked;
    public Sprite locked;

    private bool isLevelComplete = false;

    private void Update()
    {
        if(bob != null && bob.transform.position.x >= 60 && !isLevelComplete) {
            LevelComplete();
            isLevelComplete = true;
        }
    }
    private void LevelComplete() {
            PlayerPrefs.SetInt("Level2Completed", 1);
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
