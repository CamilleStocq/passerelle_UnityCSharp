using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] private float delay; //temps qu'on met avant de transformer l'objet

    void Update()
    {
        if (delay > 0f)
        {
            delay -= Time.deltaTime; // on enleve le temps qui est passé entre chaque frame
            if (delay <= 0f) // est ce que mtn il n'y en a plus ?
            {
                
            }
        }
    }
}
