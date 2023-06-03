using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int lives = 3;
    public bool isDying = false;

    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {
        lives--;
        animator.SetInteger("Lives", lives);
        if (lives <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.GetComponent<AIPath>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        isDying = true;
    }

    private void DeleteZombie()
    {
        Destroy(gameObject);
    }
}
