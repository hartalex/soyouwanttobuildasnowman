using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    public IList objects = new ArrayList();
    public IList labels = new ArrayList();
    public GameObject blackHat;
    // Use this for initialization
    void Start()
    {
        labels.Add("Hats");
        objects.Add(blackHat);
    }

    public string[] ToStringArray()
    {
        string[] retval = new string[objects.Count + labels.Count];
        int i = 0;
        foreach (string io in labels)
        {
            retval[i++] = io;
        }
        foreach (object io in objects)
        {
            retval[i++] = ((GameObject)io).GetComponent<InventoryObject>().Name;
        }
        return retval;
    }

    public GameObject GetObjectByName(string name)
    {
        GameObject retval = null;
        foreach(object io in objects)
        {
            if (name == ((GameObject)io).GetComponent<InventoryObject>().Name)
            {
                retval = (GameObject)io;
            }
        }
        return retval;
    }
}

