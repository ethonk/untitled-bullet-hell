using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BulletHell.Events;

public class HealthBar : MonoBehaviour
{
    public RectTransform healthbar;
    public bool fill = false;

    [Header("Events")]
    [SerializeField] VoidEvent chargedEvent;

    [Header("Values")]
    public float health = 0;
    float healthGoal = 100.0f;
    public float healthbarMaxSize;

    [Header("Colors")]
    public Color32 startColor, endColor;

    private void Start()
    {
        healthbar.sizeDelta = new Vector2(healthbarMaxSize*(health/healthGoal), healthbar.sizeDelta.y);
        healthbar.GetComponent<Image>().color = startColor;
    }

    private void Update()
    {
        if (fill)
        {
            if (health < healthGoal)
            {
                health += 0.25f;
                
                if (health > 100.0f)
                    health = 100.0f;
            }    
            else
            {
                healthbar.GetComponent<Image>().color = endColor;
                fill = false;
                chargedEvent.Raise();
            }

            healthbar.sizeDelta = new Vector2(healthbarMaxSize*(health/healthGoal), healthbar.sizeDelta.y);
        }
    }

    public void FillHealthBar()
    {
        fill = true;
    }

}
