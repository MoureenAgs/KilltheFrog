using UnityEngine;

public class FrogSpawner : MonoBehaviour
{
    public GameObject frogPrefab;

    void Start()
    {
        InvokeRepeating("SpawnFrog", 1f, 2f);
    }

    void SpawnFrog()
    {
        float x = Random.Range(-7f, 7f);
        float y = Random.Range(-4f, 4f);

        Instantiate(frogPrefab, new Vector3(x, y, 0), Quaternion.identity);
    }
}
