using UnityEngine;

public class CreatBox : MonoBehaviour,IDestroyable
{

    public void DestroyObject()
    {
        Debug.Log("AAAAAARG!!!!");
        Destroy(gameObject);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
