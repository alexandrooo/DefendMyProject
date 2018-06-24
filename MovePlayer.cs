﻿using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Transform player;
    [SerializeField]
    public static float speed = 10f;
    

    void OnMouseDrag() {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x < -5f ? -5f : mousePos.x;
            mousePos.x = mousePos.x > 5f ? 5f : mousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y),
                speed * Time.deltaTime);
            
        }
    }
}
