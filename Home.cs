using UnityEngine.SceneManagement;
using UnityEngine;

public class Home : MonoBehaviour {

    void OnMouseDown()
    {
        SceneManager.LoadScene(0);
        SpawnBombs.score = 0;
    }
}
