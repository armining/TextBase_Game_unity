using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveFile : MonoBehaviour {

    [MenuItem("Window/Save File")]
    static void init()
    {
        TextEditorWindow saveFileWindow = (TextEditorWindow)EditorWindow.GetWindow(typeof(TextEditorWindow));
        saveFileWindow.Show();
    }
}
