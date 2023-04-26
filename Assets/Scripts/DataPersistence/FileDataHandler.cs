using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


//    public FileDataHandler(string dataDirPath, string dataFileName)
//    {
//        this.dataDirPath = dataDirPath;
//        this.dataFileName = dataFileName;
//    }

//    public GameData Load()
//    {
//        //use path.combine to account for different OS's having different path separators
//        //string fullPath = Path.Combine(dataDirPath, dataFileName);
//        string fullPath = dataDirPath + "/" + dataFileName;
//        GameData loadedData = null;
//        if (File.Exists(fullPath))
//        {
//            try
//            {
//                //Load the serialized data from the file
//                string dataToLoad = "";
//                using (FileStream stream = new FileStream(fullPath, FileMode.Open))
//                {
//                    using (StreamReader reader = new StreamReader(stream))
//                    {
//                        dataToLoad = reader.ReadToEnd();
//                    }
//                }

//                // deserialize the data from json back into the C# object
//                loadedData = JsonUtility.FromJson<GameData>(dataToLoad);

//            }
//            catch (Exception e)
//            {
//                Debug.LogError("error occured when trying to load data from file: " + fullPath + "\n" + e);
//            }
//        }
//        return loadedData;
//    }
//    public void Save(GameData data)
//    {
//        //use path.combine to account for different OS's having different path separators
//        //string fullPath = Path.Combine(dataDirPath, dataFileName);
//        string fullPath = dataDirPath + "/" + dataFileName;
//        try
//        {
//            // Create the directory the fie will be written to if it doesn't already exist
//            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

//            // serialize the C# game data object into Json
//            string dataTostore = JsonUtility.ToJson(data, true);

//            // write the serialized data to the file
//            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
//            {
//                using (StreamWriter writer = new StreamWriter(stream))
//                {
//                    writer.Write(dataTostore);
//                }
//            }
//        }
//        catch (Exception e)
//        {

//            Debug.LogError("Error occured when trying to save data to file: " + fullPath + "\n" + e);
//        }
//    }
//}
public class FileDataHandler
{
    private string dataDirPath = "";
    private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }
    private bool hasPermissions = false;

        private void Awake()
        {
            RequestPermissions();
        }

        public void RequestPermissions()
        {
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject packageManager = currentActivity.Call<AndroidJavaObject>("getPackageManager");
            string packageName = currentActivity.Call<string>("getPackageName");
            int permission = packageManager.Call<int>("checkPermission", "android.permission.WRITE_EXTERNAL_STORAGE", packageName);
            if (permission != 0)
            {
                string[] permissions = { "android.permission.WRITE_EXTERNAL_STORAGE" };
                AndroidJavaObject permissionRequest = new AndroidJavaObject("com.unity3d.player.PermissionRequest", permissions, 0);
                currentActivity.Call("requestPermissions", permissionRequest);
            }
        }

        public GameData Load()
        {
            if (hasPermissions || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
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
            else
            {
                Debug.LogError("Cannot load data without permissions!");
            return null;
            }
        }

        public void Save(GameData data)
        {
            if (hasPermissions || Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
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
        else
            {
                Debug.LogError("Cannot save data without permissions!");
            }
        }
    }
