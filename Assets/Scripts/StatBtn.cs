using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    [SerializeField] private InputField playerNameInput;
    private string playerName;

    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerNameInput.text))
        {
            PlayerPrefs.SetString("playerName", playerName);
            
            SceneManager.LoadScene("MainScene");
        }
    }

    public void ChoicePenguin()
    {
        PlayerPrefs.SetInt("PlayerType", 0);
    }

    public void ChoiceBox()
    {
        PlayerPrefs.SetInt("PlayerType", 1);
    }
}
