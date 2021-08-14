using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class CustomMenuItems : Editor
{
    [MenuItem("Tools/Spawn Cube")]
    public static void SpawnCube()
    {
       GameObject basePlatform =  GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    [MenuItem("Tools/Spawn Ground Platform")]
    public static void SpawnGroundPlatform()
    {
        GameObject basePlatform = GameObject.CreatePrimitive(PrimitiveType.Cube);
        basePlatform.transform.localScale = new Vector3(30, 1, 30);
    }

    [MenuItem("Tools/PLayerPrefs/Delete All")]
   public static void DeleteAllPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    
}
