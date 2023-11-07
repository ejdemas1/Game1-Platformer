using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level4ButtonController : MonoBehaviour
{
    public AudioSource buttonClick;
    public void LoadLevel4() {
        buttonClick.Play();
        StartCoroutine(LoadSceneWithDelay());
    }
    private IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level4");
    }
}
