using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greenhouse : MonoBehaviour, IInteractable
{
    public int plantLevel = 0;
    public GameObject[] plants1, plants2, plants3;
    public RegolithCount player;
    public SceneSwitcher sceneSwitcher;

    private void Start()
    {
        foreach (var plant in plants1)
        {
            plant.SetActive(false);
        }
        foreach (var plant in plants2)
        {
            plant.SetActive(false);
        }
        foreach (var plant in plants3)
        {
            plant.SetActive(false);
        }
    }

    public void UpdatePlants()
    {
        if (plantLevel == 1)
        {
            foreach (var plant in plants1)
            {
                plant.SetActive(true);
            }
        }
        else if (plantLevel == 2)
        {
            foreach (var plant in plants1)
            {
                plant.SetActive(true);
            }
            foreach (var plant in plants2)
            {
                plant.SetActive(true);
            }
        }
        else if (plantLevel == 3)
        {
            foreach (var plant in plants1)
            {
                plant.SetActive(true);
            }
            foreach (var plant in plants2)
            {
                plant.SetActive(true);
            }
            foreach (var plant in plants3)
            {
                plant.SetActive(true);
            }

            sceneSwitcher.LoadScene("WinScreen");
        }
    }

    public void OnInteract()
    {
        plantLevel = player.regolithCount;
        UpdatePlants();
    }
}
