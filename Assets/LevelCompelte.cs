
using UnityEngine;
using UnityEngine.SceneManagement
public class LevelCompelte : MonoBehaviour
{
    void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
