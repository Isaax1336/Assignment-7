using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
    public static string PlayerName = "Name";
    public static int PlayerScore;
    public static int HighScore = 0;
    public static float wordSpeed = 20f;
    

    public InputField PlayerNameInput;
    public Slider WordSpeedSlider;
    public Dropdown WordColorDropdown;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }

    public void ChangeSpeed()
    {
        wordSpeed = WordSpeedSlider.value;
    }




}
