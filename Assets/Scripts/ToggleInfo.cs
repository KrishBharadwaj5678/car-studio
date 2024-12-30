using UnityEngine;

public class ToggleInfo : MonoBehaviour
{
    public GameObject infoPanel;

    public void TogglePanel()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(!infoPanel.activeSelf);
        }
    }
}
