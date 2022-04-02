using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidarContraseña : MonoBehaviour
{
    string contracorrecta;
    string contrausuario;
    public Text ingresousuario;
    // Start is called before the first frame update
    void Start()
    {
        contracorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrsenia()
    {
        contrausuario = ingresousuario.text;
        if (contrausuario == contracorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña correcta");
        }
    }
    
}
