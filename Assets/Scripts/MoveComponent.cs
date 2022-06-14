using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float objectDistance = -40f;
    [SerializeField] private float despawnDistance = -110f;
    
    private bool canSpawnGround = true;

    private void Update()
    { 
       // speed = speed + 1 * Time.deltaTime;
        transform.position += -transform.forward * speed * Time.deltaTime;

        if (transform.position.z <= objectDistance && transform.CompareTag("Ground") && canSpawnGround)
        {
            ObjectSpawner.instance.SpawnGround();
            canSpawnGround = false;
            
        }

        if (transform.position.z <= despawnDistance)
        {
            canSpawnGround = true;
            gameObject.SetActive(false);
        }
        
        
    }
}