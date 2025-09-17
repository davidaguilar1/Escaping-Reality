using UnityEngine;

public class Movment : MonoBehaviour
{
    public float Astroidspeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * Astroidspeed * Time.deltaTime;
    }
}
