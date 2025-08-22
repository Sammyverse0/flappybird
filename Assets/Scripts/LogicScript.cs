using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int scoretoadd)
    {
        score += scoretoadd;
        scoretext.text = score.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void gameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
    
}
