using Unity.VisualScripting;
using UnityEngine;

public class RaggiuntoTraguardo : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    int nPenalita;
    void OnTriggerEnter(Collider other)
    {
        nPenalita = player.GetComponent<ContaPenalita>().GetPenalita();
        Debug.Log($"Congratulazioni!, Hai Vinto Con {nPenalita} penalità");
    }
}
