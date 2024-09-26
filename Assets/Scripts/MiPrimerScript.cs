using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    //Variables 
    // El Tipo de Dato  Nombre
    int saltos = 0;
    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        saltos = saltos + 1;
        /* Debug.Log("Número de choques: " + miVariable + " " + gameObject.name);
        Debug.Log("Ha chocado con: " + collision.gameObject.name);
        */

        if (saltos == primerLogroSaltos || saltos == segundoLogroSaltos || saltos == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name + " ha chocado " + saltos + " veces");
        }
    }
}
