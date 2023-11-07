using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public List<GameObject> buttons;  
    public List<Sprite> newImages;

    public void UnlockLevelButton(int levelNumber)
    {
        Image buttonImage = buttons[levelNumber].GetComponent<Image>();
        buttonImage.sprite = newImages[levelNumber];
    }

}
