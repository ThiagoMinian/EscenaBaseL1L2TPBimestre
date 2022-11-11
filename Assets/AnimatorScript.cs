using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    public Animator Anim;
    public bool hasJump;
    public float jumpForce;
    public bool isGrounded;
    private Rigidbody RB;
    public float x, y = 5;
    public float movementSpeed;
    private float rotateSpeed;

    private Vector3 PlayerMovementInput;
    private Vector2 PlayerMouseInput;
    private float xRot;
    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private float Sensativity;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Anim.SetBool("Salte", true);
                RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }
            Anim.SetBool("tocoSuelo", true);
        }
        else
        {
            estoyCayendo();
        }
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        Anim.SetFloat("VelX", x);
        Anim.SetFloat("VelY", y);

        Vector3 transformPosition = new Vector3(x * movementSpeed * Time.deltaTime, 0, y * movementSpeed * Time.deltaTime);
        transform.position += transformPosition;



        Vector3 direction = Vector3.forward * y + Vector3.right * x;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotateSpeed * Time.deltaTime);

        xRot -= PlayerMouseInput.y * Sensativity;

        transform.Rotate(0f, PlayerMouseInput.x * Sensativity, 0f);
        PlayerCamera.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

    public void estoyCayendo()
    {
        Anim.SetBool("Salte", false);
        Anim.SetBool("tocoSuelo", false);
    }
}
