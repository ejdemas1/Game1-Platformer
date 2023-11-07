using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonController : MonoBehaviour
{
    public AudioSource buttonClick;

    public void QuitGame() {
        buttonClick.Play();
        StartCoroutine(LoadSceneWithDelay());
    }

        private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}
