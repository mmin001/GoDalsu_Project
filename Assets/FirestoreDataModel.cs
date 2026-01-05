using UnityEngine;
using Firebase;
using Firebase.Firestore;
using System.Collections.Generic;

[FirestoreData]
public class UserData
{
    [FirestoreProperty]public string uid { get; set; }
    [FirestoreProperty] public string nickname { get; set; }
    [FirestoreProperty] public List<string> collected_items { get; set; }
    [FirestoreProperty] public Dictionary<string, string>  equipped_items { get; set; }

    public UserData()
    {
        uid = "";
        nickname = "";
        collected_items = new List<string>();
        equipped_items = new Dictionary<string, string>();
    }
}

[FirestoreData]
public class LocationData
{
    [FirestoreProperty] public string loc_id { get; set; }
    [FirestoreProperty] public string name { get; set; }
    [FirestoreProperty] public double latitude { get; set; }
    [FirestoreProperty] public double longitude { get; set; }
    [FirestoreProperty] public int radius { get; set; }
    [FirestoreProperty] public Dictionary<string, int> rarity_mod { get; set; }
    [FirestoreProperty] public int cooltime { get; set; }
    [FirestoreProperty] public string description { get; set; }

    public LocationData()
    {
        loc_id = "";
        name = "";
        latitude = 0;
        longitude = 0;
        radius = 10; //10m로 반경 설정
        rarity_mod = new Dictionary<string, int>();
        cooltime = 0;
        description = "";
    }

}

[FirestoreData]
public class ItemData
{
    [FirestoreProperty]public string item_id { set; get; }
    [FirestoreProperty] public string name { set; get; }
    [FirestoreProperty] public string rarity { set; get; }
    [FirestoreProperty] public string loc_id { set; get; }
    [FirestoreProperty] public string model_path { set; get; }
    [FirestoreProperty] public string description { get; set; }

    public ItemData()
    {
        item_id = "";
        name = "";
        rarity = "";
        loc_id = "";
        model_path = "";
        description = "";
    }
}

[FirestoreData]
public class AcquisitionLogData//쿨다운 판별기준
{
    [FirestoreProperty] public string uid { set; get; }
    [FirestoreProperty] public string loc_id { set; get; }
    [FirestoreProperty] public string item_id { set; get; }
    [FirestoreProperty] public string log_id { set; get; }

    [FirestoreProperty] public Timestamp timestamp { set; get; }

    public AcquisitionLogData()
    {
        uid = "";
        loc_id = "";
        item_id = "";
        log_id = "";
    }

}
