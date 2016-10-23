using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerVitals : MonoBehaviour
{

    public Slider healthSlider;
    public int maxHealth;
    public int healthFallRate;

    public Slider thristSlider;
    public int maxThrist;
    public int thristFallRate;

    public Slider hungerSlider;
    public int maxHunger;
    public int hungerFallRate;

    void Start()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;

        thristSlider.maxValue = maxThrist;
        thristSlider.value = maxThrist;

        hungerSlider.maxValue = maxHunger;
        hungerSlider.value = maxHunger;
    }

    void Update()
    {
        //VITA
        if (hungerSlider.value <= 0 && thristSlider.value <= 0)
            healthSlider.value-= Time.deltaTime / (healthFallRate * 2);
        else if(hungerSlider.value <= 0 || thristSlider.value <= 0)
            healthSlider.value -= Time.deltaTime / healthFallRate;

        if (healthSlider.value <= 0)
            CharacterDeath();


        //FAME
        if (hungerSlider.value >= 0)
            hungerSlider.value -= Time.deltaTime / hungerFallRate;
        else if (hungerSlider.value <= 0)
            hungerSlider.value = 0;
        else if (hungerSlider.value >= maxHunger)
            hungerSlider.value = maxHunger;


        //SETE
        if (thristSlider.value >= 0)
            thristSlider.value -= Time.deltaTime / thristFallRate;
        else if (thristSlider.value <= 0)
            thristSlider.value = 0;
        else if (thristSlider.value >= maxThrist)
            thristSlider.value = maxThrist;
    }

    void CharacterDeath()
    {
        //FAI QUALCOSA
    }
}
