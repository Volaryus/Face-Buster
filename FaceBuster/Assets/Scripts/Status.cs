using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Status : MonoBehaviour
{
    public Text scoreText;
    public Slider healthSlider;
    public float health=100f;
    public int score=0;

    private void Start()
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthSlider.value = health;
        if(health<=0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void IncreaseScore(int point)
    {
        score += point;
        scoreText.text = "Score: " + score;
    }
}
