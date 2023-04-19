using UnityEngine.Android;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    private string dataDirPath = "";
    private string dataFileName = "";
    private bool hasWritePermission = false;

    public FileDataHandler(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }

    public void RequestWritePermission()
    {
        // Request permission to write to external storage
        if (!hasWritePermission)
        {
            Permission.RequestUserPermission(Permission.ExternalStorageWrite);
        }
    }

    public void CheckWritePermissionStatus()
    {
        // Check if the app has permission to write to external storage
        if (Permission.HasUserAuthorizedPermission(Permission.ExternalStorageWrite))
        {
            hasWritePermission = true;
        }
    }

    public GameData Load()
    {
        //use path.combine to account for different OS's having different path separators
        //string fullPath = Path.Combine(dataDirPath, dataFileName);
        string fullPath = dataDirPath + "/" + dataFileName;
        GameData loadedData = null;
        if (File.Exists(fullPath))
        {
            try
            {
                //Load the serialized data from the file
                string dataToLoad = "";
                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }

                // deserialize the data from json back into the C# object
                loadedData = JsonUtility.FromJson<GameData>(dataToLoad);

            }
            catch (Exception e)
            {
                Debug.LogError("error occured when trying to load data from file: " + fullPath + "\n" + e);
            }
        }
        return loadedData;
    }

    public void Save(GameData data)
    {
        //use path.combine to account for different OS's having different path separators
        //string fullPath = Path.Combine(dataDirPath, dataFileName);
        string fullPath = dataDirPath + "/" + dataFileName;
        try
        {
            // Create the directory the fie will be written to if it doesn't already exist
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            // serialize the C# game data object into Json
            string dataTostore = JsonUtility.ToJson(data, true);

            // write the serialized data to the file
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataTostore);
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error occured when trying to save data to file: " + fullPath + "\n" + e);
        }
    }
}