using UnityEngine;

public class Party : MonoBehaviour
{
    private bool active;

    public float healthPoints;
    public float damageRate = .0001f;
    public GameObject opponent;
    public GameObject gameOverMessage;
    public AudioSource gameOverTrack;

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
            healthPoints -= damageRate;
        }
        if (healthPoints <= 0 || opponent.GetComponent<Enemy>().healthPoints <= 0)
        {
            active = false;
            if (healthPoints <= 0)
            {
                gameOverMessage.SetActive(true);
                GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
                gameOverTrack.Play();
            }
        }
    }
}
