using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Acne : MonoBehaviour
{
    public float timeToDie = 2f;
    public int score=2;
    public float damage=2f;
    public Status status;
    Collider2D acneCollider;
    // Start is called before the first frame update
    void Start()
    {
        acneCollider = GetComponent<Collider2D>();
        status = GameObject.FindObjectOfType<Status>();
    }

    // Update is called once per frame
    void Update()
    {
        timeToDie -= Time.deltaTime;
        if (timeToDie <= 0)
        {
            status.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        status.IncreaseScore(score);
        Destroy(gameObject);
    }
}
