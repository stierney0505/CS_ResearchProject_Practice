using System;
using UnityEngine;

public class HeadsetScript : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    
    private float x, y, z;
    public float getX() { return x; }
    public float getY() { return y; }
    public float getZ() { return z; }
    // Start is called before the first frame update
    void Start()
    {
        x = 0.00f;
        y = 1.36f;
        z = 0.00f;
    }

    // Update is called once per frame
    void Update()
    {
        x = (float)Math.Sqrt(mainCamera.transform.position.x);
        y = (float)Math.Sqrt(mainCamera.transform.position.y);
        z = (float)Math.Sqrt(mainCamera.transform.position.z);
        Vector3 movement = new Vector3(x, y, z);
        transform.position = movement;
    }
}
