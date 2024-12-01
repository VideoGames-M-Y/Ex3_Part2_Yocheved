using UnityEngine;

public class PipeSpawner : MonoBehaviour{
    public GameObject PipePrefab;
    [SerializeField] private float spawnInterval = 2f; 
    [SerializeField] private float minHeightOffset = -3f;
    [SerializeField] private float maxHeightOffset = 3f; 
    [SerializeField] private float horizontalSpacing = 5f;
    private Vector3 lastSpawnPosition;

    private void Start(){
        lastSpawnPosition = transform.position;
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnInterval);
    }

    private void SpawnPipe(){
        float randomHeight = Random.Range(minHeightOffset, maxHeightOffset);
        Vector3 spawnPosition = new Vector3(lastSpawnPosition.x + horizontalSpacing, transform.position.y + randomHeight, transform.position.z);
        Instantiate(PipePrefab, spawnPosition, Quaternion.identity);
        lastSpawnPosition = spawnPosition;
    }
}
