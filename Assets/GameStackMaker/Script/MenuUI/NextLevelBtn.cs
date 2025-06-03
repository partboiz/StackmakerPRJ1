using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelBtn : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void LevelNext()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Level2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Level3()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void Level4()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void Level5()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void Level6()
    {
        SceneManager.LoadSceneAsync(6);
    }
}
