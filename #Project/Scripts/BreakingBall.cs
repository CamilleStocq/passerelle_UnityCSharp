using UnityEngine;

public class BreakingBall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        IDestroyable thing = other.GetComponent<IDestroyable>();

        if (thing != null)
        {
            thing.DestroyObject();
        }
    }
}
