using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    //Pause menu.
    public GameObject panel;
    //Show and hide pause menu.
    bool _isPause = false;
    // Buttons pause menu (Exit, Return, Restart)
    public GameObject[] btnPause;

    public void GamePause()
    {
        // Call pause panel
        if (!_isPause)
        {
            _isPause = true;
            Time.timeScale = 0;
            panel.SetActive(true);

            btnPause[0].SetActive(false);
            btnPause[1].SetActive(true);
        }
        //Hide pause panel
        else
        {
            _isPause = false;
            // time in the game is normal
            Time.timeScale = 1;
            panel.SetActive(false);
        }
    }
    public void BtnRestartGame()
    {
        
        // time in the game is normal
        Time.timeScale = 1;
        //Loading current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
