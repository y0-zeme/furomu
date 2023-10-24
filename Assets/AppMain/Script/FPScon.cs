using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPSCon : MonoBehaviour
{
    public float x_sensi;
    public float y_sensi;
    public new GameObject camera;
    public Vector3 cameraAngle;

    bool cursorLock = true;

    [SerializeField] private float _speed=3;
    [SerializeField] private float jumpPower=3;
    private CharacterController _characterController;

    private Transform _transform;

    private Rigidbody rb;

    private int upForce;
    private float distance;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _transform = transform;

        rb = GetComponent<Rigidbody>();
        upForce = 300;
        distance = 2.0f;
    }

    void Update()
    {
        movecon();
        Jump();
        cameracon();

        UpdateCursorLock();
    }

    void movecon()
    {
        if (Input.anyKey)
        {
            var velocity = Vector3.zero;
            if (Input.GetKey(KeyCode.W))
            {
                velocity.z = _speed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                velocity.x = -_speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                velocity.z = -_speed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                velocity.x = _speed;
            }
            if (velocity.x != 0 || velocity.z != 0)
            {
                transform.position += transform.rotation * velocity;
            }
        }
    }

    void Jump()
    {
        Vector3 rayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
        Ray ray = new Ray(rayPosition, Vector3.down);
        bool isGround = Physics.Raycast(ray, distance);
        Debug.DrawRay(rayPosition, Vector3.down * distance, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            if (isGround)
                rb.AddForce(new Vector3(0, upForce, 0));
        }
    }

    void cameracon()
    {
        float x_Rotation = Input.GetAxis("Mouse X");
        float y_Rotation = Input.GetAxis("Mouse Y");
        x_Rotation = x_Rotation * x_sensi;
        y_Rotation = y_Rotation * y_sensi;
        this.transform.Rotate(0, x_Rotation, 0);
        camera.transform.Rotate(-y_Rotation, 0, 0);
        cameraAngle = camera.transform.localEulerAngles;
        if (cameraAngle.x < 280 && cameraAngle.x > 180)
        {
            cameraAngle.x = 280;
        }
        if (cameraAngle.x > 45 && cameraAngle.x < 180)
        {
            cameraAngle.x = 45;
        }
        cameraAngle.y = 0;
        cameraAngle.z = 0;
        camera.transform.localEulerAngles = cameraAngle;
    }

    public void UpdateCursorLock()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cursorLock = false;
        }
        else if (Input.GetMouseButton(0))
        {
            cursorLock = true;
        }


        if (cursorLock)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (!cursorLock)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}