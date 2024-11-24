using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PersonajeMovimiento : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    private NavMeshAgent agente;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 destino = new Vector3(movimientoHorizontal, 0, movimientoVertical) * velocidadMovimiento * Time.deltaTime;

        agente.SetDestination(destino);
    }
}