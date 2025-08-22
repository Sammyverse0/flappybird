using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float SR = 3;
    private float timer = 0;
    public float hoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SR)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }

    }
    void spawnpipe()
    {
        float lowest = transform.position.y - hoffset;
        float highest = transform.position.y + hoffset;
        Instantiate(Pipe, new Vector3(transform.position.x , Random.Range(lowest,highest),0), transform.rotation);
    }
}
