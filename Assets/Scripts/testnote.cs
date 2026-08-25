using UnityEngine;
using System.Collections;

public class testnote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 1.0f;
    public float destroyX = -6.2f;
    void FixedUpdate()
    {
        if (transform.position.x <= destroyX)
        {
            transform.position = new Vector3(-6.2f, 0, 0);
            StartCoroutine(Destroy());
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}
