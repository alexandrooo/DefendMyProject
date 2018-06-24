using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour {

    void OnMouseDown() {
        SceneManager.LoadScene(2);
        SpawnBombs.score = 0;
    }
}
