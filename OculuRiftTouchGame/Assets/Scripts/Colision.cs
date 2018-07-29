using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colision : MonoBehaviour {

    public TextMeshPro textmeshPro;

    void OnCollisionEnter(Collision col)
    {
        Count countComponent = textmeshPro.GetComponent<Count>();
        countComponent.count += 1;
        textmeshPro.SetText("punteo:{0}", countComponent.count);
        Destroy(gameObject);

    }
}
