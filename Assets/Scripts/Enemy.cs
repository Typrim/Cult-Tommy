using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
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
        //taking damage mechanic
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            healthPoints -= .03f;
        }
    }
}
