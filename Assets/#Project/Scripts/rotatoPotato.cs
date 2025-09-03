using UnityEngine;

public class rotatoPotato : MonoBehaviour
{

    public Transform potato;
    public NormalClass normal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // potato = GameObject.FindAnyObjectByType<BoxCollider>().transform;
        normal = new NormalClass(5, "bye");
        Debug.Log(normal.text);
    }

    // Update is called once per frame
    void Update()
    {
        potato.Rotate(0, 360 * Time.deltaTime, 0);
    }
}
