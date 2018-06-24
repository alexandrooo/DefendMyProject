using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnBombs : MonoBehaviour
{

    public GameObject bomb;
    public Text pointsText;
    public static int score = 0;
    public int plusScore = 1;
    public static float fall = 0.5f;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        pointsText.text = score.ToString();
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-5f, 5f), 4.65f), Quaternion.identity);
            yield return new WaitForSeconds(fall);
            score += plusScore;
        }
    }
}
