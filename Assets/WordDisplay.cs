using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    

    public void SetWord (string word)
    {
        text.text = word;

    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.black;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
        keepData.PlayerScore++;
    }

    private void Update()
    {
        transform.Translate(0f, -keepData.wordSpeed * Time.deltaTime, 0f);
    }


}
