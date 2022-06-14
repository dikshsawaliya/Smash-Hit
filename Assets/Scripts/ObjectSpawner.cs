using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    private bool canSpawnGround = false;
    
    [SerializeField] private float groundSpawnDistance = 50f;


    public static ObjectSpawner instance;

    private void Awake()
    {
        instance = this;
    }

    public void SpawnGround()
    {
        ObjectPooler.instance.SpawnFromPool("ground1", new Vector3(0, 0, groundSpawnDistance ), Quaternion.identity);
      

    }
}