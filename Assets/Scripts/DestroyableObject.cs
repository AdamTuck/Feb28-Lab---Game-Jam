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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with " + gameObject.name + ": " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Player"))
        {
            isDegrading = true;
        }
    }
}
