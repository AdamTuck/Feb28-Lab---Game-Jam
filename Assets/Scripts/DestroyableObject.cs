using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private float degradeRate;

    private MeshRenderer blockRenderer;
    private bool isDegrading;

    private float blockAlpha;

    private void Start()
    {
        blockRenderer = GetComponent<MeshRenderer>();
        blockAlpha = 1f;
    }

    void Update()
    {
        if (isDegrading)
            DegradeObject();
    }

    private void DegradeObject ()
    {
        health -= degradeRate * Time.deltaTime;

        blockAlpha = health / 100;

        blockRenderer.material.color = new Color(1f, 1f, 1f, blockAlpha);

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