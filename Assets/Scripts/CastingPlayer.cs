using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingPlayer : MonoBehaviour

{
    public static float DistanceFromTarget;
    public float ToTarget;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
     //Calculamos la distancia del objetivo con respecto al jugador
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
        {
            ToTarget = hit.distance;
            DistanceFromTarget = ToTarget;
        }
    }
}
