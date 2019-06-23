using UnityEngine;
using System.Collections.Generic;

public class SimulationPreview : MonoBehaviour
{
    public List<PreviewElement> previewElements;

    public GameObject editButton, editMode;

    public void ToggleEditMode()
    {
        editButton.SetActive(!editButton.activeSelf);
        editMode.SetActive(!editMode.activeSelf);

        foreach (PreviewElement element in previewElements)
        {
            element.ToggleEditMode();
        }
    }

    public void ApplyChanges()
    {
        editMode.SetActive(false);
        editButton.SetActive(true);

        foreach (PreviewElement element in previewElements)
        {
            element.ApplyChanges();
        }
    }
}
