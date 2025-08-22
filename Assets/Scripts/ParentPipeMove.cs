using UnityEngine;

public class ParentPipeMove : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float deadzone = -39;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
