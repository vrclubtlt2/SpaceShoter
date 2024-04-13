using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ui : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;

    public GameObject loseWindow;

    public Player player;

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = Player.Score.ToString();
        if(player == null)
        {
            loseWindow.SetActive(true);
        }
    }
    public void OnRestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Player.Score = 0;
    }
}
