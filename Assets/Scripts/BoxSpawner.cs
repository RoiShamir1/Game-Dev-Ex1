using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] GameObject boxPrefab;  
    [SerializeField] Transform[] spawnPoints;  
    [SerializeField] float spawnInterval = 0.8f; 

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, spawnInterval);
    }

    void Spawn()
    {
        if (spawnPoints == null || spawnPoints.Length == 0) return;

        foreach (var p in spawnPoints)
            if (p) Instantiate(boxPrefab, p.position, Quaternion.identity);  
    }

}
