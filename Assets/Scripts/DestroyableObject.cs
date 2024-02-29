using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float degradeRate;

    private bool isDegrading;

    void Update()
    {
        if (isDegrading)
            DegradeObject();
    }

    private void DegradeObject ()
    {
        health -= degradeRate * Time.deltaTime;

        if (health <=0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision with " + gameObject.name + ": " + other.gameObject.tag);

        if (other.gameObject.CompareTag("Player"))
        {
            isDegrading = true;
        }
    }
}