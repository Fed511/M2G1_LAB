using UnityEngine;

public class SpawnSphere : MonoBehaviour
{
    public GameObject spherePrefab;       
    public Transform spawnPoint;           

    public void Spawn()
    {
        Debug.Log("Bottone cliccato!");
        Instantiate(spherePrefab, spawnPoint.position, Quaternion.identity);
    }
}
