using Firebase.Extensions;
using Firebase.Firestore;
using System.Collections.Generic;
using System;
using UnityEngine;

public class FirebaseDataManager : MonoBehaviour
{
    public Firebase.FirebaseApp app;
    public FirebaseFirestore db;
    public static FirebaseDataManager instance;

    public List<LocationData> locationDatas = new List<LocationData>();
   
    private void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                app = Firebase.FirebaseApp.DefaultInstance;
                db = FirebaseFirestore.DefaultInstance;
                LoadLocation();
                // Set a flag here to indicate whether Firebase is ready to use by your app.
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void LoadLocation()
    {
        Query locationQuery = db.Collection("location");
        locationQuery.GetSnapshotAsync().ContinueWithOnMainThread(task =>
        {
            QuerySnapshot alllocationQuerySnapshot = task.Result;
            foreach (DocumentSnapshot documentSnapshot in alllocationQuerySnapshot.Documents)
            {
                Debug.Log(String.Format("Document data for {0} document:", documentSnapshot.Id));
                LocationData location = documentSnapshot.ConvertTo<LocationData>();
               locationDatas.Add(location);

                // Newline to separate entries
                Debug.Log($"장소:{location.name}, 좌표 : {location.longitude}, 반경 : {location.radius}, 설명 : {location.description}, 희귀도 : {location.rarity_mod}, 쿨타임 : {location.cooltime}");
            }
        });
    }
    
}
