using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float Flapstrength;
    public LogicScript logic;
    public bool birdisalive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * Flapstrength;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisalive = false;
    }
}
