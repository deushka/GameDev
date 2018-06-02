using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaOnTriggerEnter : MonoBehaviour {
    public playerControl player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(player.onPlatform);
        if (collision.gameObject.name == "player" && player.onPlatform == false)
            player.hit(15*Time.deltaTime);
    }
}
