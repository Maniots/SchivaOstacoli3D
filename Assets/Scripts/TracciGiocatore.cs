using Unity.VisualScripting;
using UnityEngine;

public class TracciGiocatore : MonoBehaviour
{

    [SerializeField]
    Transform player;

    [SerializeField]
    float speed = 5f;

    Vector3 playerPosition; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //hello
        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        TrackPlayer();
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void TrackPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition,speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
