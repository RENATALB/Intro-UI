using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComidaDeAnimalitosUI : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputCodigo;
    public TMP_InputField inputCantDias;
    string codigo;
    int cantDias;
    int comidaPerrosPequeños = 400;
    int comidaPerrosGrandes = 700;
    int comidaGatos = 300;
    int comidaAnimalIndicado;
    int cantComidaTotal;
    float precioPorCienGramos = 80;
    float precioTotal;
    
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = string.Empty;
    }

    public void calcularComida()
    {
        if(inputCantDias.text == "")
        {
            txtResultado.text = "Debe ingresar una cantidad de días";
            return;
        }
        if (inputCodigo.text == "")
        {
            txtResultado.text = "Debe ingresar un código";
            return;
        }

        codigo = inputCodigo.text; // No es igual literalmente, el = se refiere a que está almacenando la info del input
        cantDias = int.Parse(inputCantDias.text);

        if (cantDias <3)
        {
            txtResultado.text = "La cantidad de días no puede ser menor que 3";
            return;
        }
        

        if (codigo == "G")
        {
            comidaAnimalIndicado = comidaGatos;
        } else if (codigo == "PP")
        {
            comidaAnimalIndicado = comidaPerrosGrandes;
        } else if (codigo == "PG")
        {
            comidaAnimalIndicado = comidaPerrosPequeños;
        } else
        {
            txtResultado.text = "Código no válido";
            return;
        }

        cantComidaTotal = comidaAnimalIndicado * cantDias;
        precioTotal = cantComidaTotal / 100 * precioPorCienGramos;

        txtResultado.text = "Para ese período se necesitan " + cantComidaTotal + " gramos de alimento, que saldrán $" + precioTotal;
    }
}
