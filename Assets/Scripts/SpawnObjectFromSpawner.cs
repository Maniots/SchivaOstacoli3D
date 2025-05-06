using UnityEngine;

public class SpawnObjectFromSpawner : MonoBehaviour
{
    [SerializeField]
    Transform spawner1;
    [SerializeField]
    Transform spawner2;
    [SerializeField]
    Transform spawner3;
    [SerializeField]
    Transform spawner4;
    [SerializeField]
    Transform sphere;
    Vector3 spwnpos1;
    Vector3 spwnpos2;
    Vector3 spwnpos3;
    Vector3 spwnpos4;
    
    void Start()
    {
        spwnpos1 = new Vector3(spawner1.position.x,spawner1.position.y,spawner1.position.z);
        spwnpos2 = new Vector3(spawner2.position.x,spawner2.position.y,spawner2.position.z);
        spwnpos3 = new Vector3(spawner3.position.x,spawner3.position.y,spawner3.position.z);
        spwnpos4 = new Vector3(spawner4.position.x,spawner4.position.y,spawner4.position.z);
        InvokeRepeating("SpawnObjectEvery15Sec",0f,15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjectEvery15Sec()
    {
        Instantiate(sphere,spwnpos1,spawner1.rotation);
        Instantiate(sphere,spwnpos2,spawner2.rotation);
        Instantiate(sphere,spwnpos3,spawner3.rotation);
        Instantiate(sphere,spwnpos4,spawner4.rotation);
        
    }

    
}
