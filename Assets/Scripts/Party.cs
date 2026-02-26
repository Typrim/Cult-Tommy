using UnityEngine;

public class Party : MonoBehaviour
{
    private bool active;

    public float healthPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthPoints = 1f;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            healthPoints -= .01f;
        }
    }
}
