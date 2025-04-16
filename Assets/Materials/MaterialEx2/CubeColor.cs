using UnityEngine;

public class CubeColor : MonoBehaviour
{
    public Material materialePiattaforma; // Materiale da applicare a tutti i figli

    void Start()
    {
        // Ottieni tutti i Renderer nei figli dell'oggetto vuoto
        Renderer[] renderers = GetComponentsInChildren<Renderer>();

        // Applica il materiale a tutti i Renderer
        foreach (Renderer rend in renderers)
        {
            rend.material = materialePiattaforma;
        }
    }
}
