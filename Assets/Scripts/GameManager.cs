using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerNameText;
    [SerializeField] private GameObject penGuin;
    [SerializeField] private GameObject box;
    [SerializeField] private SpriteRenderer playerSprite;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("playerName");
        if (PlayerPrefs.GetInt("PlayerType") == 0)
        {
            penGuin.SetActive(true);
        }
        else
        {
            box.SetActive(true);
        }
        playerNameText.text = playerName;
    }
}
