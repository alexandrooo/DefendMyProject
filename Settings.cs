using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public Slider difficultySlider;
     void Start()
    {

    }

    public void Mute() {
        AudioListener.pause = !AudioListener.pause;
    }

    void Update()
    {
        MovePlayer.speed = 10 / (difficultySlider.value * 2f + 1f);
        print(MovePlayer.speed);
        SpawnBombs.fall = 1 / (difficultySlider.value * 4f + 2f);
        print(MovePlayer.speed);

    }


}


 
