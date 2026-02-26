using UnityEngine;

public class Party : MonoBehaviour
{
    public float healthPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthPoints = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        healthPoints -= .01f;
    }
}
