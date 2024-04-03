using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{

public GameObject player;
public GameObject platformPrefab;
public GameObject springPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.StartsWith("Platform"))
        {
            if (Random.Range(1, 8) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (10 + Random.Range(0.4f, 1.0f))), Quaternion.identity);
            } else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (10 + Random.Range(0.4f, 1.0f)));
            }

        } else if(collision.gameObject.name.StartsWith("Spring"))
        {
            if (Random.Range(1, 8) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (10 + Random.Range(0.4f, 1.0f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (10 + Random.Range(0.4f, 1.0f))), Quaternion.identity);
            }
        }
    }
}
