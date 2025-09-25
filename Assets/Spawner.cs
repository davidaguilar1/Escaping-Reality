using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Astoid;
    public float spawnInterval = 2f; // time in between spawning 
    private float timer = 0f; // tracking time 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            timer = 0f;
            Instantiate(Astoid, transform.position, transform.rotation);
        }
    }
}
