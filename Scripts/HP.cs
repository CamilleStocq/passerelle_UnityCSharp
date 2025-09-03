using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] private int maxHp = 10;
    [HideInInspector] public int currentHp;

    void Start()
    {
        currentHp = maxHp;
    }

    void Update()
    {

    }
    void ResetHP()
    {
        currentHp = maxHp;
    }

     public void LevelUp()
    {
        // maxHP += 5
    }
}

