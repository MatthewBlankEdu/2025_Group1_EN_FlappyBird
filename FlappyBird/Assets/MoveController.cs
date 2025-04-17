using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float speed;
    public float spawnPositionX;
    public float despawnPositionX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime,
            transform.position.y, transform.position.z);

        if(transform.position.x <= despawnPositionX)
        {
            transform.position = new Vector3(spawnPositionX, transform.position.y, transform.position.z);
        }
    }
}
