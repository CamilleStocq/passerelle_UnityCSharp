using UnityEngine;

public class First : MonoBehaviour
{

    [HideInInspector] public int a = 3;
    private int b = 10;

    public HP hp;

    void Start()
    {

        Debug.Log($"A vaut {a}");
    }

    void Update()
    {
        hp.currentHp -= 1;
        // hp.Heal(10);
    }

}
