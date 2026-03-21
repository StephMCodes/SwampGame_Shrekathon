using UnityEngine;
using System.Collections.Generic;


public class ObjectiveManager : MonoBehaviour
{
    // Tracks Objectives
    private static Dictionary<WORDENUM, bool> objectiveDict = new Dictionary<WORDENUM, bool>
    {
        { WORDENUM.Pumpkin, false },
        { WORDENUM.Rat, false },
        { WORDENUM.Wand, false },
        { WORDENUM.Weapon, false }
    };

    private static int OnionCount = 0;


    public static void setObjectiveStatus(WORDENUM objectiveName, bool value)
    {
        if (objectiveDict.ContainsKey(objectiveName))
        {
            Debug.Log($"Setting objective '{objectiveName}' to {value}.");
            objectiveDict[objectiveName] = value;
        }
        else
        {
            Debug.LogWarning($"Objective '{objectiveName}' does not exist in the dictionary.");
        }

        UIHandler.updateObjectiveCounters();
    }

    public static bool getObjectiveStatus(WORDENUM objectiveName)
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
