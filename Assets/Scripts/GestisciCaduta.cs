using UnityEngine;

public class GestisciCaduta : MonoBehaviour
{

    Rigidbody myRigidBody;

    MeshRenderer mesh;

    [SerializeField]
    float TempoCaduta = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TempoCaduta)
        {
            myRigidBody.useGravity = true;
            mesh.enabled = true;
        }
    }
}
