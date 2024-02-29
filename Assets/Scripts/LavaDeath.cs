using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDeath : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameOverCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(player);
            gameOverCanvas.SetActive(true);
        }
    }
}