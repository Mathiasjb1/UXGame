using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    public Renderer cubeRenderer;
    public GameObject cube;
    [SerializeField] private Color newColor;
    [SerializeField] private Color[] colors;
    private int colorValue;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    public void ChangeMaterial()
    {
        newColor = Random.ColorHSV();
        cubeRenderer.material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
