using UnityEngine;

public class StaticExemple : MonoBehaviour
{

    public static string staticVar;
    public string normalVar;


    void Awake()
    {
        staticVar = "Coucouuuuuuuu";
    }

    public static void PrintStaticVar()
    {
        Debug.Log(staticVar);
    }
}
