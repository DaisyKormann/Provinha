using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText, finalScoreText, recordText;
    public GameObject gameOverWindow; // janela
    
 
    public void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Método chamado quando o jogo termina
    public void GameOver(int finalScore, int record)
    {
        finalScoreText.text = "Final Score: " + finalScore.ToString();
        recordText.text = "Record: " + record.ToString();
        gameOverWindow.SetActive(true);
        Time.timeScale = 0; // Pausa o jogo
    }

    // Método para reiniciar o jogo
    public void Restart()
    {
        Time.timeScale = 1; // Retoma o tempo de jogo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recarrega a cena atual
    }
}


