using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class TextEditorWindow : EditorWindow
{
    //string m_string = "Type here";
    //Color m_backgroundColor;
    //public Text mainText;

    //[MenuItem("Window/Text Editor")]
    //static void Init()
    //{
    //    TextEditorWindow window = (TextEditorWindow)EditorWindow.GetWindow(typeof(TextEditorWindow));
    //    window.Show();
    //    Selection.selectionChanged += selectionChanged;
    //}

    //private static void selectionChanged()
    //{
    //    if(Selection.activeGameObject != null)
    //    {
    //        BuildComponentList(Selection.activeGameObject);
    //    }
    //}

    //private static void BuildComponentList(GameObject gobj)
    //{
    //    var result = gobj.GetComponent<MonoBehaviour>();
    //}


    public class HandleTextFile
    {
        [MenuItem("Tools/Write file")]
        static void WriteString()
        {
            string path = "Assets/Resources/test.txt";

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Test");
            writer.Close();

            //Re-import the file to update the reference in the editor
            AssetDatabase.ImportAsset(path);
            TextAsset[] asset = (TextAsset[])Resources.LoadAll("");
            //Print the text from the file
            Debug.Log(asset);
        }

        [MenuItem("Tools/Read file")]
        static void ReadString()
        {
            string path = "Assets/Resources/test.txt";

            //Read the text from directly from the test.txt file
            StreamReader reader = new StreamReader(path);
            Debug.Log(reader.ReadToEnd());
            reader.Close();
        }

    }







    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        Text MainTextField = GameObject.Find("MainText").GetComponent<Text>();
        MainTextField.text = EditorGUILayout.TextField("Block name ", MainTextField.text);

        if (GUILayout.Button("Save"))
        {
           
        }

        
    }

    void Save()
    {
        StoryData data = new StoryData();
        FileStream fs = new FileStream("DataFile.asset", FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, data);
        fs.Close();
    }

    void Load()
    {
        FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
        BinaryFormatter formatter = new BinaryFormatter();
        StoryData data = (StoryData)formatter.Deserialize(fs);
        fs.Close();
    }
}