using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;

        void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector3 posicion = transform.position;
        posicion.x += inputX * velocidad * Time.deltaTime;
        transform.position = posicion;


        
    }
}