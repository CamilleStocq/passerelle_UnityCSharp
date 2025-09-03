using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] private float delay; //temps qu'on met avant de transformer l'objet
    float otherTime;

    void Start()
    {
        otherTime = Time.time;
        StartCoroutine(TimerCoroutine());
        StartCoroutine(Disco());
    }

    void Update()
    {
        if (delay > 0f)
        {
            delay -= Time.deltaTime; // on enleve le temps qui est passé entre chaque frame
            if (delay <= 0f) // est ce que mtn il n'y en a plus ?
            {
                ChangeColor(Color.hotPink);
            }
        }
    }

    IEnumerator TimerCoroutine() // IEnumerator est une methode comme void
    {
        // laisser passer la priorité 
        yield return new WaitForSeconds(delay * 2); // yield tourjours avec son return

        ChangeColor(Color.aquamarine);
    }

    IEnumerator Disco()
    {
        while (true)
        {
            ChangeColor(Random.ColorHSV());

            yield return true; // break, on revient la frame d'apres
        }
    }

    void ChangeColor(Color col) // changer une couleur qu'on veut plus simplement
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = col;
    }
}
