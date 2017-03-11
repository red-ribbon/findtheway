﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupIntersections : MonoBehaviour {

    private enum dirs {NE, NW, SE, SW};
    private static string path = "Prefabs/Arrow";

	// Use this for initialization
	void Start () {

        GameObject[] arrows = Resources.LoadAll<GameObject>(path);

        GameObject[] intersections = GameObject.FindGameObjectsWithTag("I");		
        foreach (GameObject i in intersections)
        {
            Intersection inter = i.AddComponent<Intersection>();

            for (int count = 0; count < i.transform.childCount; count++)
            {
                GameObject child = i.transform.GetChild(count).gameObject;
                child.AddComponent<Arrow>();

                if (child.name == dirs.NE.ToString())
                {
                    GameObject a = Instantiate(arrows[0], child.transform);
                    a.transform.localPosition = Vector3.zero;
                    a.SetActive(false);
                    inter.AddArrow(a);

                } else if (child.name == dirs.NW.ToString())
                {
                    GameObject a = Instantiate(arrows[1], child.transform);
                    a.transform.localPosition = Vector3.zero;
                    a.SetActive(false);
                    inter.AddArrow(a);
                }
                else if (child.name == dirs.SE.ToString())
                {
                    GameObject a = Instantiate(arrows[2], child.transform);
                    a.transform.localPosition = Vector3.zero;
                    a.SetActive(false);
                    inter.AddArrow(a);
                }
                else if (child.name == dirs.SW.ToString())
                {
                    GameObject a = Instantiate(arrows[3], child.transform);
                    a.transform.localPosition = Vector3.zero;
                    a.SetActive(false);
                    inter.AddArrow(a);
                }
            }
        }
    }
	

	
}
