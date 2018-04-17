using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public Material idleMaterial;
    public Material mouseOverMaterial;
    public Material mouseDownMaterial;

    private SkinnedMeshRenderer myRenderer;
    private Animator myAnimator;
    private bool isSelected = false;

	// Use this for initialization
	void Start () {
        myRenderer = GetComponent<SkinnedMeshRenderer>();
        myAnimator = GetComponentInParent<Animator>();
	}

    private void OnMouseEnter()
    {
        myRenderer.material = mouseOverMaterial;
        Debug.Log("Mouse Enter");
        isSelected = true;
    }

    private void OnMouseExit()
    {
        myRenderer.material = idleMaterial;
        Debug.Log("Mouse Leave");
        isSelected = false;
    }

    private void OnMouseDown()
    {
        if (isSelected)
        {
            myRenderer.material = mouseDownMaterial;
            Debug.Log("Button Clicked");
            myAnimator.SetTrigger("clicked");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
