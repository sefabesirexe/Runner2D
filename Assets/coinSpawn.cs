using UnityEngine;

public class coinspawn : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 2f;
    public float spawnX = 10f; // Start just off-screen to the right
    public float[] spawnY = new float[2] { 0f, 3f }; // Two Y positions
    public int minCoinsPerRow = 3;
    public int maxCoinsPerRow = 6;
    public float spacing = 0.6f; // Spacing between coins in a row

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            // Choose random Y row (0 or 1)
            float y = spawnY[Random.Range(0, spawnY.Length)];

            // Choose how many coins to spawn in this row
            int coinCount = Random.Range(minCoinsPerRow, maxCoinsPerRow + 1);

            for (int i = 0; i < coinCount; i++)
            {
                float x = spawnX + i * spacing;
                Vector3 spawnPos = new Vector3(x, y, 0f);
                Instantiate(coinPrefab, spawnPos, Quaternion.identity);
            }
        }
    }
}