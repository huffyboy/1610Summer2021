using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private const float spawnDelay = 1.5f;
    private float spawnTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnTimer > spawnDelay)
        {
            spawnTimer = 0.0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
