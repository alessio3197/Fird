﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentGenerator : MonoBehaviour 
{
    // Ensure this is initialised in the inspector:
    public GameObject[] backgrounds;
    //private GameObject environment;

    // Start is called before the first frame update
    void Start()
    {
        //environment =
        InstantiateEnvironment(backgrounds);
    }

    // This accepts as a parameter a global variable so that this can work with the test suite
    public GameObject InstantiateEnvironment(GameObject[] backgrounds)
    {
        if (backgrounds.Length < 1)
        {
            Debug.Log("The environments array is empty. Please initialise it.");
            return null;
        }
        else
        {
            //environment = InstantiateEnvironment(backgrounds);

    // This accepts as a parameter a global variable so that this can work with the test suite
    public GameObject InstantiateEnvironment(GameObject[] backgrounds)
    {
        int backgroundSpriteChoice = Random.Range(0, backgrounds.Length);
        Vector2 spawnPosition = new Vector2(0.0f, 0.0f);
        return Instantiate(backgrounds[backgroundSpriteChoice], spawnPosition, Quaternion.identity);
    }
}
