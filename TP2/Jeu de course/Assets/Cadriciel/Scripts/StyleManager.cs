using UnityEngine;
using System.Collections;

public class StyleManager : MonoBehaviour {

    int stylePoints = 0;

    void OnTriggerEnter(Collider other) {
        string otherStr = other.gameObject.name + other.gameObject.GetComponentInParent<Rigidbody>().name;
        //Debug.Log(otherStr);
        if (otherStr == "ColliderBodyJoueur 1")
        {
            stylePoints += 10;
            
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 25, 150, 20), "Style Points : " + stylePoints);
    }
}
