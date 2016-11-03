using UnityEngine;
using System.Collections;

public class accelScript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        string otherStr = other.gameObject.name + other.gameObject.GetComponentInParent<Rigidbody>().name;
        //Debug.Log(otherStr);
        if (otherStr == "ColliderBodyJoueur 1")
        {
            Rigidbody victim = other.gameObject.GetComponentInParent<Rigidbody>();
            victim.velocity = victim.velocity * 10;
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(50f, 50f, 50f) * Time.deltaTime);
    }
}
