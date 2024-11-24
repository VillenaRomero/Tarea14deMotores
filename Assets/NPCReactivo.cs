using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NPCReactivo : MonoBehaviour
{
    public Transform puntoLlegada;
    public float distanciaActivacion = 5f;

    private NavMeshAgent agente;
    private bool activado = false;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Jugador");
        if (jugador != null)
        {
            float distanciaJugador = Vector3.Distance(transform.position, jugador.transform.position);

            if (distanciaJugador < distanciaActivacion && !activado)
            {
                activado = true;
                agente.SetDestination(puntoLlegada.position);
            }
        }
    }
}
