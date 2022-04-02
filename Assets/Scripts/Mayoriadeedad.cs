using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mayoriadeedad : MonoBehaviour
{
    public int edadusuario;
    // Start is called before the first frame update
    void Start()
    {
        if (edadusuario >= 18)
        {
            Debug.Log("Es mayor de edad");
        }
        else
        {
            Debug.Log("No es mayor de edad");
        }
    }


}
