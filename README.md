# GoDalsu

### 📊 Database Schema

#### 1. Users (사용자 정보)
| 필드명 | 타입 | 설명 |
| :--- | :--- | :--- |
| `uid` | String | Firebase Auth 고유 식별자 |
| `nickname` | String | 사용자 닉네임 |
| `collected_items` | List<String> | 획득한 아이템 ID 리스트 |
| `equipped_items` | Map<String, String> | 장착 중인 아이템 (부위: ID) |

#### 2. Locations (관광 명소 정보)
| 필드명 | 타입 | 설명 |
| :--- | :--- | :--- |
| `loc_id` | String | 장소 고유 식별자 |
| `name` | String | 명소 이름 |
| `latitude` | Double | 위도 (GPS) |
| `longitude` | Double | 경도 (GPS) |
| `radius` | Int | 인식 반경 (미터 단위) |
| `rarity_mod` | Map<String, Int> | 희귀도 보정치 (확률 가중치) |
| `cooltime` | Int | 재획득 가능 대기 시간 (초 단위) |
| `description` | String | 명소 설명 및 스토리 |

#### 3. Items (액세서리 아이템)
| 필드명 | 타입 | 설명 |
| :--- | :--- | :--- |
| `item_id` | String | 아이템 고유 식별자 |
| `name` | String | 아이템 이름 |
| `rarity` | String | 희귀도 (Common, Rare, SR) |
| `loc_id` | String | 연관 장소 ID |
| `model_path` | String | Storage 내 3D 모델 경로 |

#### 4. Acquisition_Logs (획득 기록)
| 필드명 | 타입 | 설명 |
| :--- | :--- | :--- |
| `log_id` | String | 로그 고유 식별자 |
| `uid` | String | 사용자 ID |
| `loc_id` | String | 획득 장소 ID |
| `item_id` | String | 획득 아이템 ID |
| `timestamp` | Timestamp | 획득 시각 (Server Time) |
