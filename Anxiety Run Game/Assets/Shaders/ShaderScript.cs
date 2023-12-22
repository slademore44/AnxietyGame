using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderScript : MonoBehaviour
{

    //Material outlineShader;

    public MeshRenderer myRenderer;

    public Material myShader;

    public Vector3 myScale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        myRenderer = GetComponent<MeshRenderer>();

        myRenderer.materials[1] = new Material(Shader.Find("Unlit/Texture"));

        myShader = myRenderer.materials[1];

        myScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);

        myShader.SetVector("_Object_Scale", myScale);

    }
}
