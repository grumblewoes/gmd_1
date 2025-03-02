using UnityEngine;

public class FireWorksManager : MonoBehaviour
{
    public GameObject firework;
    public Vector2 spawnAreaMin = new Vector2(-10f, -5f);
    public Vector2 spawnAreaMax = new Vector2(10f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnFirework();
        }
    }

    void SpawnFirework() {
        if (firework != null) {
            float randomX = Random.Range(spawnAreaMin.x, spawnAreaMin.y);
            float randomY = Random.Range(spawnAreaMax.x, spawnAreaMax.y);
            Vector3 spawnPos = new Vector3(randomX, randomY, 0f);

            Instantiate(firework, spawnPos, Quaternion.identity);
        }
    }
}
