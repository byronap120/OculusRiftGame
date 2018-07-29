using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Count : MonoBehaviour {

    public int count;

	// Use this for initialization
	void Start () {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("punteo:{0}", count);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
