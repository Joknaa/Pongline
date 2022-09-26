using UnityEngine;

public class MovementController : MonoBehaviour {
    [SerializeField] private float moveSpeed;

    private Rigidbody2D _rigidbody2D;
    private float _elapsedTime;


    void Start() {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (Input.GetAxisRaw("Vertical") == 0) {
            _rigidbody2D.velocity = Vector2.zero;
            return;
        }

        var targetPosition = _rigidbody2D.position + Vector2.up * (Input.GetAxisRaw("Vertical") * moveSpeed * Time.fixedDeltaTime);

        if (targetPosition.y > 16) targetPosition.y = 16;
        if (targetPosition.y < -16) targetPosition.y = -16;
        
        _rigidbody2D.MovePosition(targetPosition);
        
    }
}