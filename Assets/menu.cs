using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {


    public void Jugar()
    {
        Debug.Log("jugar pulsado");
    }
    public void Acercade()
    {
        Debug.Log("Acerca de pulsado");
        Application.LoadLevel(0);
    }
    public void Instrucciones()
    {
        Debug.Log("Instrucciones Pulsado");
        Application.LoadLevel(2);
    }
}
