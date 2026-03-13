using UnityEngine;
using UnityEngine.InputSystem;

public class Enemy : MonoBehaviour
{
    private bool active;
    public float healthPoints;
    public GameObject opponent;
    public GameObject victoryMessage;
    public AudioSource victoryTrack;

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
            if (healthPoints <= 0 || opponent.GetComponent<Party>().healthPoints <= 0)
            {
                active = false;
                if (healthPoints <= 0)
                {
                    victoryMessage.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
                    victoryTrack.Play();
                }
            }
        }
    }
}
