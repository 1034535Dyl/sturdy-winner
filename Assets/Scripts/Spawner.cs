using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private int amount;

    [SerializeField]
    private GameObject prefab;

    public void SpawnObjects()
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(prefab, transform.position, Quaternion.Euler(
                0f,
                Random.Range(0f, 360f),
                0f));
        }
    }
}