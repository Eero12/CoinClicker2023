using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Config")]
    [SerializeField] private string fileName;
    private GameData gameData;
    private List<IDataPersistence> dataPersistenceObjects;
    private FileDataHandler dataHandler;
    public static DataPersistenceManager instance { get; private set; }

    private void Awake()
    {
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        if (instance != null)
        {
            Debug.LogError("Found more than one Data Persistance Manager in the scene.");
        }
        instance = this;
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        LoadGame();

        Debug.Log(Application.persistentDataPath);
    }

    private void Start()
    {
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }

    public void LoadGame()
    {
        //Load any saved data from a file using the data handler.
        this.gameData = dataHandler.Load();

        //if no data can be loaded, initialize to a new game.
        if (this.gameData == null)
        {
            NewGame();
        }

        //antaa tallennetut tiedot kaikille scripteille jotka sitä tarvii
        foreach (IDataPersistence dataPersisteceObj in dataPersistenceObjects)
        {
            dataPersisteceObj.LoadData(gameData);
        }


    }

    public void SaveGame()
    {
        //pass the data to other scripts so they can update it
        foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.SaveData(ref gameData);
        }

        //save that data to a file using the data handler
        dataHandler.Save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
    private void OnApplicationPause(bool pause)
    {
        SaveGame();
        
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<GameManager>();
        Debug.Log(FindObjectsOfType<GameManager>().Count());
        return new List<IDataPersistence>(dataPersistenceObjects);
    }
}
