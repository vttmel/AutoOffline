# Thần Hành Phù (THP) — Tài liệu kỹ thuật

## 1. Kiến trúc tổng quan

Hệ thống THP trong auto bot hoạt động theo luồng sau:

```
User chọn web game (comboBoxGameOfWeb)
  → method_18() trong Form1.cs
    → Class37.int_1 = int.Parse(string_7[i, 2])   ← Server ID
    → Class37.smethod_107()                         ← Dispatch theo int_1
      → smethodXX()                                 ← Config map cho server đó
        → mapNavigationEntry_0[] được build

Nhân vật chính dùng THP (buttonTHP_Click)
  → method_30() trong Form1.cs
    → đọc comboBoxTHP.Text → tra string_18
    → nếu route string (không phải số): Class29.smethod_5(char, routeString)
    → nếu số: Class29.smethod_7(char, mapID, direction)

Nhân vật phụ theo master vào map mới
  → Class29.smethod_7() (slave follow logic)
    → tra mapID trong mapNavigationEntry_0[]
    → tính tọa độ gần nhất từ POS string
    → dùng route string để navigate THP dialog
```

---

## 2. string_7 — Cấu hình server

**File:** `ns100/Form1.cs`  
**Khai báo:** `public static string[,] string_7 = new string[N, 6]`

| Col | Ý nghĩa | Ví dụ |
|-----|---------|-------|
| [i,0] | Tên hiển thị (comboBoxGameOfWeb) | `"JX Offline - Mel"` |
| [i,1] | Loại shop mua vật phẩm (TCVN3) | `"VËt phÈm"` |
| [i,2] | **Server ID** — dùng làm `Class37.int_1` | `"2000"` |
| [i,3] | NPC filter | `"1,5"` hoặc `null` |
| [i,4] | Tên file exe game | `"Game.exe"` |
| [i,5] | THP-CTC flag (bật THP cho nhân vật phụ) | `"1"` hoặc `null` |

> **Quan trọng:** col[5]="1" để nhân vật phụ tự dùng THP. Nếu null thì slave không tự navigate.

**Thêm server mới:**
1. Đổi `new string[N, 6]` → `new string[N+1, 6]`
2. Thêm entry vào cuối array
3. Chọn Server ID **duy nhất** không trùng với server nào đã có

**Server ID đã dùng (không dùng lại):** 0, 7, 12, 19, 20, 31, 34, 40, 45, 47, 52, 55, 58, 62, 65, 68, 88, 105, 111, 118, 121, 130, 131, 134, 142, 144, 146, 152, 158, 622009–622043, 662035, 662042, 662044, 662045, 1000–1034, v.v.

---

## 3. smethod_107() — Dispatch theo Server ID

**File:** `ns34/Class37.cs`

Hàm này là một chuỗi `if/else if` kiểm tra `int_1` và gọi smethod tương ứng:

```csharp
else if (int_1 == 2000)
{
    smethod_108();   // ← smethod của server JX Offline - Mel
}
```

Khi **thêm server mới**, thêm branch này vào smethod_107().

---

## 4. smethodXX() — Config map của từng server

Mỗi server có một hàm riêng để build `mapNavigationEntry_0`. Cấu trúc chuẩn:

```csharp
private static void smethod_108()   // tên đặt tùy ý, không trùng
{
    mapNavigationEntry_0 = null;
    int_2 = null;
    string text = "thÇn hµnh";      // TCVN3 cho "thần hành" — dùng để match THP item
    string text2 = "luyÖn c«ng";    // TCVN3 cho "luyện công"

    // Thành thị, thôn trang, môn phái, chiến trường Tống Kim
    smethod_5(ref mapNavigationEntry_0, text + "|µnh thÞ", null, text + "|Th«n tr",
              null, text + "|«n ph¸i", null, text + "|Tèng Ki", null, "Þ trÝ k");

    // Bản đồ cấp 90
    smethod_3(ref mapNavigationEntry_0, "cÊp 90|" + text2);

    // Bản đồ tân thủ (lv20–80) — theo level bracket
    smethod_4(ref mapNavigationEntry_0, "t©n thñ|" + text2, new LevelBracketMapGroup[7]
    {
        new LevelBracketMapGroup { levelBracket = 20, mapIds = new int[] { 19, 7, 179 } },
        // ... các bracket khác
    });

    // Sinh Tử Lệnh
    string string_ = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y";
    smethod_7(ref mapNavigationEntry_0, 1000, "Sinh T|" + text, string_);
    smethod_7(ref mapNavigationEntry_0, 355, "Sinh T|" + text, string_);

    // Các map đặc thù của server — thêm bằng smethod_6()
    smethod_6(ref mapNavigationEntry_0, 1010, "Héi Qu¸n|Héi Qu¸n Vâ L©m|" + text,
        "POS|53568,107360,...");
    // ...
}
```

---

## 5. Route String — Định dạng điều hướng dialog THP

### 5.1 Nguyên lý hoạt động

Route string là chuỗi các **partial match** cách nhau bằng `|`:

```
"Héi Qu¸n|Héi Qu¸n Vâ L©m|thÇn hµnh"
```

Bot đọc tất cả option hiện tại trong dialog. Với mỗi option, nó kiểm tra xem option đó có **chứa** (substring) bất kỳ segment nào trong route không. Khi tìm thấy:
1. Click option đó
2. **Xóa segment đã match** khỏi route string
3. Đọc dialog mới, lặp lại

**Ví dụ navigation:**

| Bước | Dialog options | Route còn lại | Match | Hành động |
|------|---------------|---------------|-------|-----------|
| 1 | `"§i ®Õn Héi Qu¸n Vâ L©m"`, `"§i ®Õn Tu LuyÖn Cèc"`, ... | `["Héi Qu¸n", "Héi Qu¸n Vâ L©m", "thÇn hµnh"]` | "Héi Qu¸n" ∈ "§i ®Õn Héi Qu¸n Vâ L©m" | Click, remove "Héi Qu¸n" |
| 2 | `"Héi Qu¸n Vâ L©m"`, `"Linh Thñy Ng­ Th«n"`, `"Rêi kh¸i"` | `["Héi Qu¸n Vâ L©m", "thÇn hµnh"]` | "Héi Qu¸n Vâ L©m" ∈ "Héi Qu¸n Vâ L©m" | Click → teleport |

> **Quan trọng:** Vì segment bị xóa sau khi click, không cần lo về việc "Héi Qu¸n" match cả sub-menu "Héi Qu¸n Vâ L©m" — khi vào sub-menu "Héi Qu¸n" đã bị xóa rồi.

### 5.2 Segment "thÇn hµnh" ở cuối route

Segment này giúp filter tránh click nhầm option "Hoạt động" khi navigate hướng (Đông/Tây/Nam/Bắc) trong một số context. Các smethod trong Class37 đều append `| text` vào cuối route string.

---

## 6. smethod_6() — Thêm map đơn lẻ

```csharp
smethod_6(ref mapNavigationEntry_0,
    int mapID,          // Map ID trong game
    string routeString, // Chuỗi navigate dialog THP
    string posString,   // Tọa độ spawn (POS format)
    ...
    bool bool_0 = false // true = append dù trùng mapID
);
```

### 6.1 POS String — Format tọa độ đơn

```
"POS|x,y,TênVịTrí"
```

**Tọa độ** = tile coordinate × 32:
- Game lua `NewWorld(mapID, tileX, tileY)`
- POS value: `tileX * 32`, `tileY * 32`

**Ví dụ:**
```
NewWorld(1010, 1674, 3355)  →  "POS|53568,107360,Héi Qu¸n Vâ L©m"
                                       ↑           ↑
                                  1674*32       3355*32
```

### 6.2 POS String — Nhiều vị trí trong cùng 1 map

Dùng khi cùng mapID có nhiều sub-destination (tọa độ khác nhau **và** route THP khác nhau):

```
"POS|x1,y1,Tên1route1_dùng_gạch|x2,y2,Tên2route2_dùng_gạch"
```

- `` phân tách **tên vị trí** và **route override** của vị trí đó
- `_` trong route override được replace thành `|` khi dùng — do `|` sẽ split POS string
- Bot tính khoảng cách từ vị trí master đến từng POS entry, chọn cái **gần nhất**, rồi dùng route override của entry đó

**Ví dụ cho mapID 1010 (Hội Quán có 2 sub-location):**

```csharp
smethod_6(ref mapNavigationEntry_0, 1010,
    "Héi Qu¸n|Héi Qu¸n Vâ L©m|" + text,   // route default (fallback)
    "POS|53568,107360,Héi Qu¸n Vâ L©mHéi Qu¸n_Héi Qu¸n Vâ L©m_" + text
       + "|56384,111392,Linh Thñy Ng­ Th«nHéi Qu¸n_Linh Thñy_" + text);
```

Khi master ở tọa độ (56384, 111392):
- Entry gần nhất: Linh Thủy Ngư Thôn
- Route override: `"Héi Qu¸n_Linh Thñy_thÇn hµnh"` → sau replace `_`→`|`: `"Héi Qu¸n|Linh Thñy|thÇn hµnh"`
- Bot navigate THP đến đúng Linh Thủy ✓

---

## 7. string_18 — Dropdown THP cho nhân vật chính

**File:** `ns100/Form1.cs`  
**Khai báo:** `public static string[,] string_18 = new string[N, 2]`

| Col | Ý nghĩa |
|-----|---------|
| [i,0] | Tên hiển thị trong comboBoxTHP (UTF-8 bình thường) |
| [i,1] | Route string (TCVN3 Latin-1) hoặc Map ID (số) |

- Nếu col[1] là **số**: method_30() gọi Class29.smethod_7() — teleport trực tiếp theo mapID + direction
- Nếu col[1] là **chuỗi**: method_30() gọi Class29.smethod_5() — navigate THP dialog theo route

**Khi thêm destination mới:**
1. Đổi `new string[N, 2]` → `new string[N+1, 2]`
2. Thêm entry với route string tương ứng (TCVN3)

---

## 8. TCVN3 trong C# source

Các ký tự tiếng Việt trong Class37.cs và Form1.cs route strings được lưu dưới dạng Latin-1 Unicode code points (giá trị số bằng với TCVN3 byte tương ứng):

| Tiếng Việt | TCVN3 byte | Unicode char | C# literal |
|-----------|-----------|-------------|------------|
| ầ (Hội) | 0xE9 | é (U+00E9) | `é` hoặc `é` |
| á (Quán) | 0xB8 | ¸ (U+00B8) | `¸` hoặc `¸` |
| õ (Võ) | 0xE2 | â (U+00E2) | `â` |
| â (Lâm) | 0xA9 | © (U+00A9) | `©` |
| ệ (Luyện) | 0xD6 | Ö (U+00D6) | `Ö` |
| ố (Cốc) | 0xE8 | è (U+00E8) | `è` |
| ề (Huyền) | 0xD2 | Ò (U+00D2) | `Ò` |
| ơ (Cơ) | 0xAC | ¬ (U+00AC) | `¬` |
| ấ (Cấp) | 0xCA | Ê (U+00CA) | `Ê` |
| ủ (Thủy) | 0xF1 | ñ (U+00F1) | `ñ` |
| ư (Ngư) | 0xAD | ­ (U+00AD) | `­` |
| ô (Thôn) | 0xAB | « (U+00AB) | `«` |

> **Quy tắc:** Byte TCVN3 `0xXX` = Unicode char `U+00XX`. Giá trị số giống nhau.
>
> **Không dùng** `­` trực tiếp trong tên file — đó là soft hyphen (invisible). Trong C# string literal thì an toàn.

---

## 9. Workflow thêm server mới từ đầu

### Bước 1 — Xác định Server ID
Chọn một số **chưa có trong string_7** (xem danh sách mục 2). Ví dụ: **2000**.

### Bước 2 — Thêm vào string_7 (Form1.cs)
```csharp
// Đổi new string[N, 6] → new string[N+1, 6]
{ "Tên server", "VËt phÈm", "2000", "1,5", "Game.exe", "1" }
```

### Bước 3 — Viết smethodXX() (Class37.cs)
Copy cấu trúc từ `smethod_41()` hoặc smethod khác gần nhất, điều chỉnh:
- Các bracket map luyện công (smethod_4)
- Các map đặc thù của server bằng smethod_6()

### Bước 4 — Đăng ký trong smethod_107() (Class37.cs)
```csharp
else if (int_1 == 2000)
{
    smethodXX();
}
```

### Bước 5 — Thêm destination vào string_18 (Form1.cs)
```csharp
// Đổi new string[N, 2] → new string[N+1, 2]
{ "Tên hiển thị", "route|string|TCVN3" },
```

### Bước 6 — Build
```
"C:\Program Files (x86)\Microsoft Visual Studio\2022\BuildTools\MSBuild\Current\Bin\MSBuild.exe" kykeoxe.csproj -p:Configuration=Release -p:Platform=x86 -verbosity:minimal
```
Output: `bin\x86\Release\net40\JXOfflineAuto.exe`

---

## 10. Config hiện tại — JX Offline - Mel

### string_7 entry
```csharp
{ "JX Offline - Mel", "VËt phÈm", "2000", "1,5", "Game.exe", "1" }
```
Server ID = **2000** → kích hoạt `smethod_108()`

### Destinations (string_18)
| Tên UI | Route | Map ID |
|--------|-------|--------|
| Hội Quán VL | `Héi Qu¸n\|Héi Qu¸n Vâ L©m` | 1010 |
| Linh Thủy Ngư Thôn | `Héi Qu¸n\|Linh Thñy` | 1010 |
| Huyền Cổ Các | `HuyÒn C¬` | 1025 |
| Tu Luyện 10–80 | `LuyÖn Cèc\|10-80\|CÊp XX` | 1011–1018 |
| Tu Luyện 90–180 | `LuyÖn Cèc\|90-180\|CÊp XX` | 1019–1024 |

### Map coords (từ thanhanhphu.lua)
| Destination | MapID | Tile X,Y (lua) | POS (×32) |
|-------------|-------|----------------|-----------|
| Hội Quán Võ Lâm | 1010 | 1674, 3355 | 53568, 107360 |
| Linh Thủy Ngư Thôn | 1010 | 1762, 3481 | 56384, 111392 |
| Huyền Cơ Các | 1025 | 1576, 3226 | 50432, 103232 |
| Tu Luyện Cốc (tất cả) | 1011–1024 | 1651, 3168 | 52832, 101376 |

### Menu THP trong thanhanhphu.lua
```
Main menu:
  1. Thành thị / Thôn trang / Môn phái / Chiến trường Tống Kim
  2. Bản đồ luyện công (cấp 90 + tân thủ)
  3. Thiết lập điểm hồi sinh
  4. Đi đến Hội Quán Võ Lâm  →  sub: Hội Quán VL / Linh Thủy Ngư Thôn
  5. Đi đến Tu Luyện Cốc      →  sub: 10-80 / 90-180  →  sub: Cấp XX
  6. Đi đến Huyền Cơ Các      →  direct teleport
  7. Rời khỏi
```
