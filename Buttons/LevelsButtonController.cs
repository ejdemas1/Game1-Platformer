using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsButtonController : MonoBehaviour
{
    public AudioSource buttonClick;

    public void LoadLevelsScreen() {
        buttonClick.Play();
        StartCoroutine(LoadSceneWithDelay());
    }
    private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Levels");
    }

}
