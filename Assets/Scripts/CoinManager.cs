using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject Coin;
    public float spawnInterval = 2f;
    public float despawnTime = 5f;
    public int maxCoins = 3;

    private float spawnTimer;
    private int coinsOnScreen;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f && coinsOnScreen < maxCoins)
        {
            SpawnCoin();
            spawnTimer = spawnInterval;
        }

    }
    private void SpawnCoin()
    {
        // Instantiate a new coin at a random position within a certain range
        Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0f);
        GameObject coin = Instantiate(Coin, spawnPosition, Quaternion.identity);
        coinsOnScreen++;

        // Destroy the coin after the despawn time if it is not hit
        Destroy(coin, despawnTime);
    }
    public void CoinHit()
    {
        coinsOnScreen--;
    }
}
