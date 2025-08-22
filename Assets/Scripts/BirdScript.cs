using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float Flapstrength;
    public LogicScript logic;
    public bool birdisalive = true;

    private InputSystem_Actions inputActions;

    void Awake()
    {
        // Initialize input actions
        inputActions = new InputSystem_Actions();
    }

    void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Attack.performed += ctx => Flap();
    }

    void OnDisable()
    {
        inputActions.Player.Attack.performed -= ctx => Flap();
        inputActions.Player.Disable();
    }

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void Flap()
    {
        if (birdisalive)
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
