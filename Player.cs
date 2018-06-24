using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public GameObject home;
    public Text text;
    public Text text1;
    public Text text2;
    public GameObject restart;
    public Button pauseButton;
    public static bool lose = false;
    public int record;

    void Awake()
    {
        lose = false;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        text.text = "YOUR SCORE: " + SpawnBombs.score;
        text1.text = "";
        restart.SetActive(true);
        home.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        lose = true;
        if (PlayerPrefs.GetInt ("record") < SpawnBombs.score) {
            PlayerPrefs.SetInt("record", SpawnBombs.score);
        }
        text2.text = "Your score " + record;
    }

}
