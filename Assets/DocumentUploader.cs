using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class DocumentUploader : MonoBehaviour
{
    public List<LocationData> locationDatas = new List<LocationData>()
    {   new LocationData()
        {
            loc_id = "loc_001",
            name = "Central Park",
            latitude = 40.785091,
            longitude = -73.968285,
            radius = 50,
            rarity_mod = new Dictionary<string, int>()
            {
                { "common", 70 },
                { "rare", 25 },
                { "epic", 5 }
            },
            cooltime = 10,
            description = "A large public park in New York City."
        },
        new LocationData()
        {
            loc_id = "loc_002",
            name = "Eiffel Tower",
            latitude = 48.858370,
            longitude = 2.294481,
            radius = 30,
            rarity_mod = new Dictionary<string, int>()
            {
                { "common", 60 },
                { "rare", 30 },
                { "epic", 10 }
            },
            cooltime = 15,
            description = "An iconic iron lattice tower in Paris."
        }
    };
}
