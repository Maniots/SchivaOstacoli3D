using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;


public class OggettoColpito : MonoBehaviour
{    
    //[SerializeField]
    //Color color;
    //[SerializeField]
    //Material material;
    [SerializeField]
    ColorDropdown colorDropdown = new ColorDropdown();
    MeshRenderer ambiente;  
    public enum ColorDropdown
    {
        Red, 
        Blue, 
        Yellow
    };

    
    private void Start()
    {
        ambiente = GetComponent<MeshRenderer>();
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log($"L'oggetto {other.gameObject.name} si è schiantato contro di me:{gameObject.name}");
            CambiaColoreMateriale();
            gameObject.tag = "Colpito";
        }
        //Destroy(gameObject);
    }

    void CambiaColoreMateriale()
    {
        if(colorDropdown == ColorDropdown.Red)
        {
            ambiente.material.color = Color.red;
        }
        else if(colorDropdown == ColorDropdown.Blue)
        {
            ambiente.material.color = Color.blue;
        }
        else
        {
            ambiente.material.color = Color.yellow;
        }
    }
}
