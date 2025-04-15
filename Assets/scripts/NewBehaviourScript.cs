using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string nombreAlumno;
    public int anio;
    public string especialidad;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "" || anio < 1 || anio > 5)
        {
            Debug.Log("Error: no se pueden ingresar cadenas vacías");
            return;
        }
        //Si se ingresa un valor diferente a las opciones válidas en el campo ingreso de orientación escribir en consola “Solo puede ingresar T, D, G, M o H”.
        if (especialidad !="T" && especialidad != "M" && especialidad != "G" && especialidad !="D" && especialidad != "H")
        {
            Debug.Log("Solo se puede ingresar T, D, M, G o H");
            return;
        }
        if (anio < 3)
        {
            Debug.Log("Aun estas en ek ciclo básico");
            return;
        }
        Debug.Log("Muchas gracias " + nombreAlumno + "!");
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
