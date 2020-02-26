using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScenes : MonoBehaviour
{

    public void LoadScene(int i) {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + i);
    }
}
