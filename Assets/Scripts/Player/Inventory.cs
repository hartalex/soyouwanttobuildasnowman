

using System.Collections;
using UnityEngine;

public static class Inventory
{
    private static bool started = false;
    private static IList objectstrings = new ArrayList();
    private static IList labels = new ArrayList();

    public static void SetStarted(bool val)
    {
        started = val;
    }
  
    public static bool GetStarted()
    {
        return started;
    }
    public static void addObject(string name)
    {
        if (!exists(name))
        {
            objectstrings.Add(name);
        }
    }

    private static bool exists(string name)
    {
        bool retval = false;
        int i = 0;
        while (i < objectstrings.Count && !retval)
        {
            if (name == (string)objectstrings[i])
            {
                retval = true;
            }
            i++;
        }
        return retval;
    }

    public static string[] ToStringArray()
    {
        string[] retval = new string[objectstrings.Count + labels.Count];
        int i = 0;
        foreach (string io in labels)
        {
            retval[i++] = io;
        }
        foreach (object io in objectstrings)
        {
            retval[i++] = (string)io;
        }
        return retval;
    }

    public static GameObject GetObjectByName(string name)
    {
        GameObject retval = null;
        foreach(object io in objectstrings)
        {
            if (name == (string)io)
            {
                retval = (GameObject)Resources.Load((string)io, typeof(GameObject));  
            }
        }
        return retval;
    }
}

