using UnityEngine;

public class FollowPath : MonoBehaviour
{

    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float travelTime;

    private float startTime;

    void Start()
    {
        transform.position = startPoint.position; // deplacement de l'objet
        startTime = Time.time;
    }

    void Update()
    {
        float t = (Time.time - startTime) / travelTime;
        // mettre l'objet à une certaine distance des deux points en fonction du temps
        // Lerp() = onse met à un point de depart et de fin et bien on a le pourcentage parcouru
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
    }
}
