using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public string leveltoload;

   public void loadlevel ()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(leveltoload);
    }
}
