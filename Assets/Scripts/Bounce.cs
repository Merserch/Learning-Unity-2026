using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
        
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
            {
            speed = speed * -1;
            }
    }
}
