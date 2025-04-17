using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject John;

    // Update is called once per frame
    void Update()
    {
        if (John == null) return;
        Vector3 position = transform.position;
        position.x = John.transform.position.x;
        transform.position = position;
    }
}
