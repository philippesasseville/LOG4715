using UnityEngine;
using System.Collections;

public class bananaScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        string otherStr = other.gameObject.name + other.gameObject.GetComponentInParent<Rigidbody>().name;
        //Debug.Log(otherStr);
        if (otherStr == "ColliderBodyJoueur 1")
        {
            Rigidbody victim = other.gameObject.GetComponentInParent<Rigidbody>();
            victim.angularVelocity = new Vector3(0f, 20.0f, 0f);
            victim.velocity = victim.velocity / 3;
            Destroy(this.gameObject);
        }
    }

    void Update() {
        transform.Rotate(new Vector3(50f,50f,50f) * Time.deltaTime);
    }
}
