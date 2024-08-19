using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreUI, finalScoreUI, recordUI;
    GameManager gameOverWindow; // janela
    void Start()
    {
        
    }

    // Update is called once per frame
 public void UpdateScoreText()
    {
        
    }
    public void GameOver(int score, int record, bool newRecord)
    {
         gameOverWindow.SetActive(true);
        finalScoreUI.text = "Pontuação: " + score.ToString("0000");
        recordUI.text = "Recorde: " + record.ToString("0000");
    }
}
