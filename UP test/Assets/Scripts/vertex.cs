using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertex : MonoBehaviour
{
    // Start is called before the first frame update
    public float displacementAmout;
    private MeshRenderer meshRenderer;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        displacementAmout = Mathf.Lerp(displacementAmout, 0, Time.deltaTime);
        meshRenderer.material.SetFloat("_Amout", displacementAmout);

        if (Input.GetButtonDown("Jump"))
        {
            displacementAmout += 1f;
        }
    }
}
