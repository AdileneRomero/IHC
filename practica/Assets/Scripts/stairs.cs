using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairs: Interactable
{
    public Material activeMaterial;
    public Material inactiveMaterial;
    private MeshRenderer meshRenderer;

    private void Star()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = inactiveMaterial;
    }

   public override void Interact(){
        base.Interact();
        meshRenderer.material = activeMaterial;
    }
}
