using UnityEngine;

public class LaunchProjectiles : MonoBehaviour
{
    [SerializeField]
    GameObject projectile;
    [SerializeField]
    float launchVelocity = 700f;
    [SerializeField]
    Transform spawner1;
    [SerializeField]
    Transform spawner2;
    [SerializeField]
    Transform spawner3;
    [SerializeField]
    Transform spawner4;
    [SerializeField]
    Transform spawner5;
    [SerializeField]
    Transform spawner6;
    [SerializeField]
    Transform spawner7;
    [SerializeField]
    Transform spawner8;
    [SerializeField]
    Transform spawner9;
    [SerializeField]
    Transform spawner10;
    [SerializeField]
    Transform spawner11;
    [SerializeField]
    Transform spawner12;
    Vector3 spwnpos1;
    Vector3 spwnpos2;
    Vector3 spwnpos3;
    Vector3 spwnpos4;
    Vector3 spwnpos5;
    Vector3 spwnpos6;
    Vector3 spwnpos7;
    Vector3 spwnpos8;
    Vector3 spwnpos9;
    Vector3 spwnpos10;
    Vector3 spwnpos11;
    Vector3 spwnpos12;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spwnpos1 = new Vector3(spawner1.position.x,spawner1.position.y,spawner1.position.z);
        spwnpos2 = new Vector3(spawner2.position.x,spawner2.position.y,spawner2.position.z);
        spwnpos3 = new Vector3(spawner3.position.x,spawner3.position.y,spawner3.position.z);
        spwnpos4 = new Vector3(spawner4.position.x,spawner4.position.y,spawner4.position.z);
        spwnpos5 = new Vector3(spawner5.position.x,spawner5.position.y,spawner5.position.z);
        spwnpos6 = new Vector3(spawner6.position.x,spawner6.position.y,spawner6.position.z);
        spwnpos7 = new Vector3(spawner7.position.x,spawner7.position.y,spawner7.position.z);
        spwnpos8 = new Vector3(spawner8.position.x,spawner8.position.y,spawner8.position.z);
        spwnpos9 = new Vector3(spawner9.position.x,spawner9.position.y,spawner9.position.z);
        spwnpos10 = new Vector3(spawner10.position.x,spawner10.position.y,spawner10.position.z);
        spwnpos11 = new Vector3(spawner11.position.x,spawner11.position.y,spawner11.position.z);
        spwnpos12 = new Vector3(spawner12.position.x,spawner12.position.y,spawner12.position.z);
        InvokeRepeating("SpawnProjectilesEvery5Sec",0f,5f);
    }

    void SpawnProjectilesEvery5Sec()
    {
        GameObject ball1 = Instantiate(projectile,spwnpos1,spawner1.rotation);
        GameObject ball2 = Instantiate(projectile,spwnpos2,spawner2.rotation);
        GameObject ball3 = Instantiate(projectile,spwnpos3,spawner3.rotation);
        GameObject ball4 = Instantiate(projectile,spwnpos4,spawner4.rotation);
        GameObject ball5 = Instantiate(projectile,spwnpos5,spawner5.rotation);
        GameObject ball6 = Instantiate(projectile,spwnpos6,spawner6.rotation);
        GameObject ball7 = Instantiate(projectile,spwnpos7,spawner7.rotation);
        GameObject ball8 = Instantiate(projectile,spwnpos8,spawner8.rotation);
        GameObject ball9 = Instantiate(projectile,spwnpos9,spawner9.rotation);
        GameObject ball10 = Instantiate(projectile,spwnpos10,spawner10.rotation);
        GameObject ball11 = Instantiate(projectile,spwnpos11,spawner11.rotation);
        GameObject ball12 = Instantiate(projectile,spwnpos12,spawner12.rotation);
        ball1.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball3.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball4.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball5.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball6.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball7.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball8.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball9.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball10.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball11.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        ball12.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (launchVelocity, 0,0));
        if(gameObject.tag == "Terreno")
        {
            Destroy(ball1);
            Destroy(ball2);
            Destroy(ball3);
            Destroy(ball4);
            Destroy(ball5);
            Destroy(ball6);
            Destroy(ball7);
            Destroy(ball8);
            Destroy(ball9);
            Destroy(ball10);
            Destroy(ball11);
            Destroy(ball12);
            
        }
                                                
        
    }
}
