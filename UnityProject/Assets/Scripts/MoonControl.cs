using UnityEngine;

public class MoonControl : MonoBehaviour
{
    public float distance = 1000f;
    public float scale = 15.0f;




    void Start()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, distance);
        transform.localScale = new Vector3(scale, scale, scale);

    }
}
