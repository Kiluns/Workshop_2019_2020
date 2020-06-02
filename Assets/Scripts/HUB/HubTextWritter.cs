using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HubTextWritter : MonoBehaviour
{
    private TextMeshProUGUI uiText;
    private string textToWrite;
    private int characterIndex;
    private float timePerCharacter;
    private float timer;

    public void AddWriter(TextMeshProUGUI uiText, string textToWrite, float timePerCharacter)
    {
        this.uiText = uiText;
        this.textToWrite = textToWrite;
        this.timePerCharacter = timePerCharacter;
        characterIndex = 0;
    }

    public void Update()
    {
        if (uiText != null)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                if(characterIndex >= textToWrite.Length)
                {
                    uiText = null;
                    return;
                }

                timer += timePerCharacter;
                characterIndex++;
                uiText.text = textToWrite.Substring(0, characterIndex);
            }
        }
    }
}