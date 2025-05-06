using System.Collections.Generic;
using UnityEngine;

public class AttivaProiettili : MonoBehaviour
{

    [SerializeField]
    List<GameObject> proiettili;

    void Start()
    {
        DisableProjectiles();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EnableProjectiles();
        }
    }

    void EnableProjectiles()
    {
        foreach (GameObject projectile in proiettili)
        {
            projectile.SetActive(true);
        }
    }

    void DisableProjectiles()
    {
        foreach (GameObject projectile in proiettili)
        {
            projectile.SetActive(false);
        }
    }
}

