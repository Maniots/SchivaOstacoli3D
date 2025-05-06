using UnityEngine;

public class ContaPenalita : MonoBehaviour
{
    int nPenalita = 0;
    public int GetPenalita()
    {
        return nPenalita;
    }
    private void OnCollisionEnter(Collision other)
    {
        // ogni collisione incrementiamo il nostro numero di penalità
        if(other.gameObject.name != "Terreno")
        {
            if(other.gameObject.tag != "Colpito" && gameObject.tag == "Player")
            {
                nPenalita += 1;
                Debug.Log($"{other.gameObject.name} ha sbattuto contro {gameObject.name}, Ha Sbattuto {nPenalita}");

            }
        }
    }
}
