using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour {
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float maxLookUpAngle = 80f;
    [SerializeField] private float maxLookDownAngle = -80f;
    [SerializeField] [Range(0f, 1f)] private float lookSensitivity = 0.2f;

	private Rigidbody rb;
    private Camera cam;

    private Vector2 moveInput;
    private float verticalRotation;
    private float horizontalRotation;
    private bool canLook = true;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }

    private void OnMove(InputValue value) {
        moveInput = value.Get<Vector2>();
        moveInput *= moveSpeed;
	}

    private void OnLook(InputValue value) {
        if (!canLook) {
            return;
        }

        Vector2 delta = value.Get<Vector2>() * lookSensitivity;
        verticalRotation += delta.y;
        verticalRotation = Mathf.Clamp(verticalRotation, maxLookDownAngle, maxLookUpAngle);
        cam.transform.localRotation = Quaternion.Euler(-verticalRotation, 0, 0);

        horizontalRotation += delta.x;
        transform.rotation = Quaternion.Euler(0, horizontalRotation, 0);
    }

    private void OnConfiguration() {
        bool isActive = GameManger.uiConfigure.gameObject.activeInHierarchy;
        GameManger.instance.ShowConfigureUI(!isActive);
        canLook = isActive;
    }

    private void Update() {
        Vector3 dir = transform.forward * moveInput.y + transform.right * moveInput.x;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }
}
