using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    public List<GameObject> listaPatron;
    public List<GameObject> listaJugador;

    public GameObject winText;

    void Start()
    {
        winText.SetActive(false);
    }

    public void AgregarPad(GameObject pad)
    {
        listaJugador.Add(pad);

        VerificarPatron();
    }

    void VerificarPatron()
    {
        // Si todavía no completa el patrón
        if (listaJugador.Count != listaPatron.Count)
            return;

        // Comparar uno por uno
        for (int i = 0; i < listaPatron.Count; i++)
        {
            if (listaJugador[i] != listaPatron[i])
            {
                Debug.Log("Patrón incorrecto");
                return;
            }
        }

        // Si todo coincide
        Debug.Log("YOU WIN");
        winText.SetActive(true);
    }
}