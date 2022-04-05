using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio9 : MonoBehaviour
{

    public string nombre1;
    public string nombre2;
    public string nombre3;

    public float capitalaportado1;
    public float capitalaportado2;
    public float capitalaportado3;

    float porcentaje1;
    float porcentaje2;
    float porcentaje3;


    float montototal;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Nombre: " + nombre1 + ", capital aportado: $ " + capitalaportado1 + ", Porcentaje del capital: % " + porcentaje1 + ", Monto total aportado: $"+ montototal);
        Debug.Log("Nombre: " + nombre2 + ", capital aportado: $ " + capitalaportado2 + ", Porcentaje del capital: % " + porcentaje2 + ", Monto total aportado: $"+ montototal);
        Debug.Log("Nombre: " + nombre3 + ", capital aportado: $ " + capitalaportado3 + ", Porcentaje del capital: % " + porcentaje3 + ", Monto total aportado: $"+ montototal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
