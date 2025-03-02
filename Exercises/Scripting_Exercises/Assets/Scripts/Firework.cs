using Unity.Mathematics;
using UnityEngine;

public class Firework : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float lifetime = 3f;
    public GameObject explosionPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
    
    void OnDestroy()
    {
        if (explosionPrefab != null) {
            Instantiate(explosionPrefab, transform.position, quaternion.identity);
        }
    }
}
