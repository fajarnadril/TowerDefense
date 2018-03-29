using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;

    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        Debug.Log("Test");
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
        Debug.Log("Test");
    }

}
