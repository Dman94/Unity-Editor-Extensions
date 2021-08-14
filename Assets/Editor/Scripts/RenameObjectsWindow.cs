using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RenameObjectsWindow :EditorWindow
{
[MenuItem("Tools/Rename Objects/Rename object from selection")]
  static void RenameObject()
    {
        EditorWindow window = GetWindow(typeof(RenameObjectsWindow));
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Select an object in the scene heiarchy that you want to rename");
        if (Selection.activeGameObject)
        {
            Selection.activeGameObject.name = EditorGUILayout.TextField("Object name: ", Selection.activeGameObject.name);
        }
        
        Repaint();
    }
}

public class RenameMultipleObjectsWindow : EditorWindow
{
    string inputName = "";

    [MenuItem("Tools/Rename Objects/Rename multiple object from selection")]
    static void RenameObject()
    {
        EditorWindow window = GetWindow(typeof(RenameMultipleObjectsWindow));
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Select all object in the scene  that you want to rename");
        inputName = Selection.activeGameObject.name = EditorGUILayout.TextField("Object name: ", Selection.activeGameObject.name);

        int numOfObjectsSelected = Selection.gameObjects.Length;
        if(numOfObjectsSelected > 0)
        {
            for(int index = 0; index < numOfObjectsSelected; index++)
            {
                Selection.gameObjects[index].name = inputName;
            }
        }
        Repaint();
    }


}
