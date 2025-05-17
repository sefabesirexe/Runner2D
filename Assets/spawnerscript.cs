using UnityEngine;

public class spawnerscript : MonoBehaviour

{
    public GameObject prefabToSpawn1;
    public GameObject prefabToSpawn2;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float spawnIntervalA = 5f;
    public float spawnIntervalB = 3f;

    public float minSpeed = 2f;
    public float maxSpeed = 5f;

    public bool spawnA = true;
    public bool spawnB = false;

    [Range(0f, 1f)] public float spawnChance1 = 0.5f;
    [Range(0f, 1f)] public float spawnChance2 = 0.5f;

    private void Start()
    {
        InvokeRepeating(nameof(AttemptSpawnA), 5f, spawnIntervalA);
        InvokeRepeating(nameof(AttemptSpawnB), 5f, spawnIntervalB);
    }

    void AttemptSpawnA()
    {
        // Randomly decide whether to spawn from each point
        if (Random.value < spawnChance1)
        {
            SpawnA(spawnPoint1);
        }
    }
    void AttemptSpawnB()
    {

        if (Random.value < spawnChance2)
        {
            SpawnB(spawnPoint2);
        }
    }

    void SpawnB(Transform spawnPoint)
    {
        GameObject instance = Instantiate(prefabToSpawn1, spawnPoint.position, Quaternion.identity);

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.left * randomSpeed;
        }
    }

     void SpawnA(Transform spawnPoint)
    {
        GameObject instance = Instantiate(prefabToSpawn2, spawnPoint.position, Quaternion.identity);

        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.left * randomSpeed;
        }
    }

}
