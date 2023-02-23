using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    static string saveFileName = "saveData.dat";
    static string jsonFileName = "jsonData.dat";



    public static void SaveGame()
    {
        Debug.Log("Saving...");
        string path = GetFilePath(saveFileName);

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        SaveManager data = new SaveManager();
        string jsondata = JsonUtility.ToJson(data);
        WriteToFile(jsonFileName, jsondata);
        formatter.Serialize(stream, data);
        stream.Close();

       
    }



    static void WriteToFile(string fileName, string json)
    {

        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            Debug.Log("File already exist: deleting...");
            File.Delete(path);
        }

        Debug.Log("Trying to write " + path);
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    static string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }


    public static SaveManager LoadGame()
    {

        string path = GetFilePath(saveFileName);

        Debug.Log("TRYING TO LOAD THE GMAE THROUGH FILE");

        if (File.Exists(path))
        {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SaveManager data = formatter.Deserialize(stream) as SaveManager;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("save file not found on:" + path);
            return null;
        }
    }



    private static string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);

        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }

        }
        else
        {
            Debug.Log("File not FOUND");
            return "";
        }
    }

    public static string GetJsonFileName()
    {
        return saveFileName;
    }


}
