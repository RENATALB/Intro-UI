using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI TxtSaludo;
    public TMP_InputField InputNombre;
    string nombreIngresado;
    string saludo;
    
    // Start is called before the first frame update
    void Start()
    {
        TxtSaludo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        // Obtener el nombre del inputField

        nombreIngresado = InputNombre.text;

        // Concatenar el nombre con un saludo

        saludo = "¡Hola " + nombreIngresado + "!";

        // Mostrar el saludo en txtSaludo

        TxtSaludo.text = saludo;
    }
}
