using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{
    private Renderer render;
    private float finalValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentValue = render.material.GetFloat("_Dissolution");

        float newValue = Mathf.Lerp(currentValue, finalValue, Time.deltaTime);

        render.material.SetFloat("_Dissolution", newValue);
        
    }

    private void OnMouseDown() {
        finalValue = 1f;
    }

}
