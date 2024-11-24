using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NPCPatrol : MonoBehaviour
{
    public Transform puntoPartida;
    public Transform puntoLlegada;

    private NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        agente.SetDestination(puntoLlegada.position);
    }

    void Update()
    {
        if (agente.remainingDistance < 0.1f)
        {
            agente.SetDestination(puntoPartida.position);
        }
    }
}
