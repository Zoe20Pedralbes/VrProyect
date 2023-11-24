using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] private const float initialLifeTime = 2;
    private float lifeTime;
    private Vector3 velocity;
    public float speedMultiplier;
    void Start()
    {
        lifeTime = initialLifeTime;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
        transform.position += velocity * Time.deltaTime;
        Debug.Log(velocity.normalized);

    }

    public void SetDirection(Vector3 direction, Transform spawnPoint)
    {
        transform.position = spawnPoint.position;
        velocity = direction * speedMultiplier;
        transform.parent = null;
    }
}
