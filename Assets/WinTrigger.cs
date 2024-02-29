using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameWinCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(player);
            gameWinCanvas.SetActive(true);
        }
    }
}
