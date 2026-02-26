using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //entity of health bar
    public GameObject entity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set slider value to health points
        if (entity.GetComponent<Enemy>())
        {
            GetComponent<UnityEngine.UI.Slider>().value = entity.GetComponent<Enemy>().healthPoints;
        }
        else if (entity.GetComponent<Party>())
        {
            GetComponent<UnityEngine.UI.Slider>().value = entity.GetComponent<Party>().healthPoints;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //update slider value to health points
        if (entity.GetComponent<Enemy>())
        {
            GetComponent<UnityEngine.UI.Slider>().value = entity.GetComponent<Enemy>().healthPoints;
        }
        else if (entity.GetComponent<Party>())
        {
            GetComponent<UnityEngine.UI.Slider>().value = entity.GetComponent<Party>().healthPoints;
        }
    }
}
