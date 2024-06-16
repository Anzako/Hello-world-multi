using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput PlayerInput;
    private InputAction movementAction;

    private Vector2 movementDirection;
    [SerializeField] private float speed = 2f;

    private void Awake()
    {
        PlayerInput = GetComponent<PlayerInput>();
        movementAction = PlayerInput.actions["Move"];
    }

    private void Update()
    {
        movementDirection = movementAction.ReadValue<Vector2>();
        float movement = speed * Time.deltaTime;
        transform.position += new Vector3(movementDirection.x * movement, 0, movementDirection.y * movement);

    }

}
