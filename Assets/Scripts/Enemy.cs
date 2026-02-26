using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    private bool active;
    public float healthPoints;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        active = true;
        healthPoints = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //taking damage mechanic
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (active) {
                healthPoints -= .03f;
            }
        }
    }
}
