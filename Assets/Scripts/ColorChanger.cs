using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;

    public void Red()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[0];
        }
    }

    public void Green()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[1];
        }
    }

    public void White()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[2];
        }
    }

    public void Black()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[3];
        }
    }

    public void Orange()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[4];
        }
    }

    public void Yellow()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[5];
        }
    }

    public void Blue()
    {
        for (int i = 0; mats.Length > i; i++)
        {
            mats[i].material.color = colors[6];
        }
    }


}
