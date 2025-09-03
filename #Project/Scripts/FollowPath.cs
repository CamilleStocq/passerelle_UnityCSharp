using System.Collections;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float travelTime;

    private float startTime;
    private Coroutine coroutine;
    private bool coroutineRunning;

    IEnumerator MoveBetweenPonits()
    {
        coroutineRunning = true;
        startTime = Time.time; // commence le mouvement
        transform.position = startPoint.position; // deplacement de l'objet
        float t;

        while (Time.time - startTime < travelTime)
        {
            t = (Time.time - startTime) / travelTime;
            transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
            // Lerp() = onse met à un point de depart et de fin et bien on a le pourcentage parcouru

            yield return true;
        }

        transform.position = endPoint.position; // pile poil à la position final
        coroutineRunning = false;


    }

    void Start()
    {
       coroutine = StartCoroutine(MoveBetweenPonits());
    }

    void Update()
    {
        // float t = (Time.time - startTime) / travelTime;
        // // mettre l'objet à une certaine distance des deux points en fonction du temps
        // transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t); 

        // if (transform.position == endPoint.position)
        // {
        // }

        if (!coroutineRunning) // si elle ne tourne pas
        {
            // on part dans l'autre sens
            Transform tmp = endPoint;
            endPoint = startPoint;
            startPoint = tmp;
            coroutine = StartCoroutine(MoveBetweenPonits()); 

        }
    }
}
