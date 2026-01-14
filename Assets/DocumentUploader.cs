using Firebase.Firestore;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Extensions;

public class DocumentUploader : MonoBehaviour
{
    public void Start()
    {
        StartUpload();
    }
    
    // cooltime 변수 c를 10으로 가정.
    private static int c = 10;

    public List<LocationData> locationDatas = new List<LocationData>()
    {
        /* --- 대구 중구 --- */
        new LocationData() {
            loc_id = "dongseongro", name = "동성로", latitude = 35.8699, longitude = 128.5960, radius = 100,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "대구의 중심 상권이며, 가장 번화한 거리"
        },
        new LocationData() {
            loc_id = "seomun_market", name = "서문시장", latitude = 35.8691, longitude = 128.5812, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "대구 최대 규모의 전통시장"
        },
        new LocationData() {
            loc_id = "kim_kwang_seok_road", name = "김광석길", latitude = 35.8603, longitude = 128.6044, radius = 80,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "가수 김광석을 기리는 벽화 거리"
        },
        new LocationData() {
            loc_id = "dongin_galbi_alley", name = "동인동찜갈비골목", latitude = 35.8753, longitude = 128.6046, radius = 80,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "매콤한 양념 찜갈비가 유명한 먹거리 골목"
        },
        new LocationData() {
            loc_id = "yangnyeongsi_museum", name = "약령시박물관", latitude = 35.8665, longitude = 128.5912, radius = 60,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "역사 깊은 약령시의 문화를 알 수 있는 한의약 박물관"
        },

        /* --- 대구 남구 --- */
        new LocationData() {
            loc_id = "anjirang_gobchang", name = "안지랑곱창골목", latitude = 35.8368, longitude = 128.5789, radius = 100,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "전국구 규모의 곱창 요리 특화 거리"
        },
        new LocationData() {
            loc_id = "apsan_cafe_street", name = "앞산 카페거리", latitude = 35.8335, longitude = 128.5830, radius = 120,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "세련된 카페가 밀집한 분위기 좋은 거리"
        },

        /* --- 대구 북구 --- */
        new LocationData() {
            loc_id = "bokhyeon_five_way", name = "복현오거리", latitude = 35.8954, longitude = 128.6174, radius = 100,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "막창 골목으로 유명한 북구의 번화가"
        },
        new LocationData() {
            loc_id = "guam_seowon", name = "구암서원", latitude = 35.8824, longitude = 128.5785, radius = 70,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "조선시대 선비의 정신이 깃든 역사 깊은 서원"
        },
        new LocationData() {
            loc_id = "knu", name = "경북대", latitude = 35.8906, longitude = 128.6113, radius = 200,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "대구의 대표적인 국립대학교 The king북대"
        },

        /* --- 대구 동구 --- */
        new LocationData() {
            loc_id = "palgongsan_cablecar", name = "팔공산케이블카", latitude = 35.9926, longitude = 128.6713, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "팔공산의 풍경을 한눈에 내려다보는 명물"
        },
        new LocationData() {
            loc_id = "chicken_gizzard_alley", name = "닭똥집골목", latitude = 35.8837, longitude = 128.6256, radius = 100,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "평화시장의 유명한 별미 닭똥집 튀김 골목"
        },
        new LocationData() {
            loc_id = "dongdaegu_station", name = "동대구역", latitude = 35.8777, longitude = 128.6286, radius = 200,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "교통과 쇼핑의 중심지인 복합환승센터"
        },
         new LocationData() {
            loc_id = "ttangttang_chicken", name = "땅땅치킨", latitude = 35.9189, longitude = 128.6293, radius = 50,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "대구에서 시작된 치킨 브랜드의 상징적인 장소. 치킨만들기 체험을 할 수 있다."
        },

        /* --- 대구 수성구 --- */
        new LocationData() {
            loc_id = "suseong_lake", name = "수성못", latitude = 35.8278, longitude = 128.6166, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "수변 산책로와 분수쇼가 아름다운 쉼터"
        },
        new LocationData() {
            loc_id = "daegu_art_museum", name = "대구미술관", latitude = 35.8236, longitude = 128.6657, radius = 120,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "현대 미술의 정수를 느낄 수 있는 문화 공간"
        },
        new LocationData() {
            loc_id = "lions_park", name = "라이온즈파크", latitude = 35.8411, longitude = 128.6815, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "삼성 라이온즈 야구팀의 홈 구장. 승리한다 삼성! 우린 믿는다 삼성!"
        },
        new LocationData() {
            loc_id = "deurangil", name = "들안길", latitude = 35.8315, longitude = 128.6163, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "대규모 식당가로 구성된 유명 먹거리 타운"
        },

        /* --- 대구 달서구 --- */
        new LocationData() {
            loc_id = "daegu_arboretum", name = "대구수목원", latitude = 35.7992, longitude = 128.5235, radius = 200,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "쓰레기 매립지를 숲으로 가꾼 도심 속 생태공원"
        },
        new LocationData() {
            loc_id = "wolkwang_waterfront_park", name = "월광수변공원", latitude = 35.7946, longitude = 128.5401, radius = 130,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "잔잔한 호수 뷰와 산책길이 훌륭한 공원"
        },
        new LocationData() {
            loc_id = "eworld_83tower", name = "이월드(83타워)", latitude = 35.8539, longitude = 128.5641, radius = 250,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "대구 최고의 랜드마크이자 놀이공원. 화장실 뷰가 좋다"
        },

        /* --- 대구 달성군 --- */
        new LocationData() {
            loc_id = "daegu_science_museum", name = "대구과학관", latitude = 35.6701, longitude = 128.4682, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "과학의 신비함을 체험하는 국립 과학관"
        },
        new LocationData() {
            loc_id = "samunjin_inn_village", name = "사문진주막촌", latitude = 35.8055, longitude = 128.4552, radius = 100,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "낙동강변의 옛 주막 정취를 느낄 수 있는 곳"
        },
        new LocationData() {
            loc_id = "songhae_park", name = "송해공원", latitude = 35.7772, longitude = 128.4892, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "옥연지 둘레길과 풍차가 아름다운 공원"
        },
        new LocationData() {
            loc_id = "spavalley", name = "스파밸리", latitude = 35.7891, longitude = 128.6258, radius = 150,
            rarity_mod = new Dictionary<string, int>() { { "common", 70 }, { "rare", 30 } },
            cooltime = c, description = "워터파크와 자연 속 휴식이 가능한 리조트"
        },

       
    };
    public void StartUpload()
    {
        FirebaseFirestore db = FirebaseFirestore.DefaultInstance;
        foreach (LocationData location in locationDatas)
        {
            DocumentReference docRef = db.Collection("location").Document(location.loc_id);
            docRef.SetAsync(location).ContinueWithOnMainThread(task =>
            {
                if (task.IsCompleted)
                {
                    Debug.Log($"Uploaded location: {location.name}");
                }
                else
                {
                    Debug.LogError($"Failed to upload location: {location.name}, Error: {task.Exception}");
                }
            });
        }
    }
}