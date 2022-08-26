using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public static event Action WallDied;
    [SerializeField] public Health health;
    [SerializeField] public int currentHealth;
    private void OnDisable()
    {
        WallDied?.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        health = new Health();
        health.ChangeHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = health.ChangeHealth;
        if(health.ChangeHealth <= 0)
        {
            Destroy(gameObject);
        }
    }



}
