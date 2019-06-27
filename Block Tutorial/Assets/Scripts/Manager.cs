using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public bool gameover = false;
    public float restartDelay = 1;
    public GameObject completeLevel;
    public Text deathText;
    static int deaths;
   
    public void EndLevel()
    {
        completeLevel.SetActive(true);
    }
    public void EndGame()
    {
        if(gameover == false)
        {
            gameover = true;
            Invoke("Restart", restartDelay);            
        }        
    }
    void Restart()
    {
        deaths += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    void Update()
    {
        deathText.text = deaths.ToString();
    }

}
