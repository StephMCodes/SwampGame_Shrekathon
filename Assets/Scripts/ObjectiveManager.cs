using UnityEngine;
using System.Collections.Generic;


public class ObjectiveManager : MonoBehaviour
{
    // Tracks Objectives
    private static Dictionary<string, bool> objectiveDict = new Dictionary<string, bool>
    {
        { "Pumpkin", false },
        { "Weapon", false }
    };

    private static int OnionCount = 0;

    public static void setObjectiveStatus(string objectiveName, bool value)
    {
        if (objectiveDict.ContainsKey(objectiveName))
        {
            objectiveDict[objectiveName] = value;
        }
        else
        {
            Debug.LogWarning($"Objective '{objectiveName}' does not exist in the dictionary.");
        }
    }

    public static bool getObjectiveStatus(string objectiveName)
    {
        if (objectiveDict.TryGetValue(objectiveName, out bool value))
        {
            return value;
        }
        else
        {
            Debug.LogWarning($"Objective '{objectiveName}' does not exist in the dictionary.");
            return false; // Default to false if the objective doesn't exist
        }
    }

    public static void incrementOnions() { 
        OnionCount++;
    }

    public static int  getOnionCount()
    {
        return OnionCount;
    }

}
