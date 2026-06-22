# 📔 JX6.0 Linux - Trợ Lý Phát Triển Script (Claude Context)

Hồ sơ này cung cấp ngữ cảnh, quy định hệ thống hàm (API) của dự án JX6.0 Võ Lâm Truyền Kỳ Linux. Trợ lý AI (Claude) phải luôn đọc và tuân thủ nghiêm ngặt các cú pháp dưới đây khi viết mã nguồn.

---

## 🚀 1. Thông Tin Nhánh & Môi Trường
- **Branch:** `mel-dev` (Nhánh phát triển và thử nghiệm tính năng mới).
- **Môi trường:** Máy ảo Linux (CentOS/Ubuntu), kết nối qua VSCode SSH.
- **Bảng mã tập tin (Encoding):** **ISO 8859-1** — bắt buộc lưu file `.lua` ở định dạng này.
- **Bảng mã tiếng Việt trong file:** **TCVN3 (ABC)** — toàn bộ chuỗi tiếng Việt bên trong script được gõ bằng bộ gõ TCVN3. Các ký tự tiếng Việt được lưu dưới dạng byte đơn (single-byte) theo bảng mã TCVN3, không phải Unicode hay Latin-1 chuẩn.
- **Quy tắc bắt buộc khi chỉnh sửa file có tiếng Việt TCVN3:**
  - ✅ Dùng **Python binary (`open(path, 'rb')` / `open(path, 'wb')`)** cho mọi thao tác đọc/ghi — đây là cách duy nhất an toàn.
  - ✅ Khi cần tìm/thay bytes chính xác, đọc file bằng `rb` trước, dùng `repr()` để lấy byte sequence, rồi mới dùng `content.replace(old_bytes, new_bytes, 1)`.
  - ❌ **Tuyệt đối không dùng Edit tool** trên các file chứa tiếng Việt TCVN3 — Edit tool sẽ reinterpret bytes và làm hỏng toàn bộ chuỗi tiếng Việt trong file.
  - ❌ Không dùng `open(path, 'w', encoding='utf-8')` hay `encoding='latin-1'` khi ghi file server có sẵn tiếng Việt.
- **Line ending:** Nhiều file server dùng **CRLF (`\r\n`)** (Windows-style). Khi patch bằng Python, phải kiểm tra line ending thực tế trước khi dùng làm search string.
