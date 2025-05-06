using System;
using UnityEngine;
using UnityEngine.UIElements;

public class GetisciMovimento : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float jumpForce = 5.0f;
    [SerializeField]
    bool isGrounded;
    private float MovementX;
    private float MovementZ;
    
    Vector3 jump;
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, jumpForce, 0.0f);
        Debug.Log("Ciao,Sono il " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        MovementandJump();
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void MovementandJump()
    {
        MovementX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        MovementZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        transform.Translate(MovementX,0f,MovementZ);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
