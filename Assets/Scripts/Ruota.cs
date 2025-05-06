using UnityEngine;


public class Ruota : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    float rotazioneX = 0f;
    [SerializeField]
    float rotazioneY = 10f;

    [SerializeField]
    float rotazioneZ = 0f;

    Vector3 vettorefinale;
    // Update is called once per frame
    void Update()
    {
        vettorefinale = new Vector3(rotazioneX,rotazioneY,rotazioneZ);
        transform.Rotate(vettorefinale * speed * Time.deltaTime);
    }
}
