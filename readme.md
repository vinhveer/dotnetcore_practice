# Bài tập ASP.NET Core

## Bài tập 1

Tạo một Project có tên `BaiTap1`, tạo một controller có tên là `CalculatorController` thực hiện chức năng nhập vào 2 số thực, chọn phép toán, tính và in kết quả có giao diện như sau:

Xây dựng trang web theo các cách tiếp nhận tham số yêu cầu:

*   Sử dụng `Request`
*   Sử dụng đối số của Action
*   Sử dụng tham số `IFormCollection`
*   Sử dụng Model

## Bài tập 2

Tạo một Project có tên `BaiTap2`, tạo một controller có tên là `StudentController` thực hiện chức năng sau:

*   Đăng ký thông tin sinh viên
*   Hiển thị thông tin sinh viên đã đăng ký
*   Tại phần đăng ký, thêm chức năng tải ảnh lên. Tại phần hiển thị thông tin sinh viên, hiện hình ảnh vừa tải lên.
*   Khi tải lại trang, thông tin sinh viên đăng ký không bị mất (Lưu thông tin sinh viên vào .txt)

## Bài tập 3

Tạo một Project có tên `BaiTap3`, tạo controller có tên là `EmailController` thực hiện đăng nhập vào email và gửi mail đến 1 địa chỉ khác (dùng mail yahoo hoặc gmail).

Thông tin gửi mail bao gồm:

*   Địa chỉ mail người gửi
*   Mật khẩu người gửi
*   Địa chỉ mail cần gửi đến
*   Tiêu đề
*   Nội dung gửi

Lưu ý, email phải nhập đúng định dạng và bắt buộc không được rỗng.

## Bài tập 4

Tạo một Layout chung và chuyển qua các tính năng được thông qua Navbar cho các bài tập 1, 2, 3. Thêm tính năng cho phép đổi logo trên Navbar.


## Bài tập 5

**Đề bài: Xây dựng web quản lý thông tin nhân viên (tìm kiếm cơ bản)**

1.  **Thiết kế cơ sở dữ liệu (CSDL)**: Tạo CSDL có tên `QLNV_MãSV` gồm 2 bảng:
    *   **Phòng ban**: (`Mã phòng ban`, `Tên phòng ban`)
    *   **Nhân viên**: (`Mã nhân viên`, `Họ nhân viên`, `Tên nhân viên`, `Giới tính`, `Ngày sinh`, `Lương`, `Ảnh nhân viên`, `Địa chỉ`, `Mã phòng ban`)
2.  **Tạo DbContext dựa trên CSDL**
3.  **Xây dựng các chức năng quản lý**:
    *   Quản lý **phòng ban** và **nhân viên** với các chức năng:
        *   **Thêm mới**
        *   **Chỉnh sửa**
        *   **Xóa**
        *   **Hiển thị danh sách**
4.  **Chức năng tìm kiếm cơ bản**:
    *   Cho phép tìm kiếm nhân viên theo các tiêu chí:
        *   Mã nhân viên
        *   Họ tên
        *   Giới tính
        *   Địa chỉ
        *   Phòng ban

## Bài tập 5
**Xây dựng web quản lý sinh viên**  

**1. Thiết kế cơ sở dữ liệu (CSDL)**  
Tạo CSDL có tên **QLSV_MãSV** gồm 3 bảng:  

- **Phòng ban (Departments)**  
  - Mã phòng ban (DepartmentID)  
  - Tên phòng ban (DepartmentName)  

- **Sinh viên (Students)**  
  - Mã sinh viên (StudentID)  
  - Họ sinh viên (LastName)  
  - Tên sinh viên (FirstName)  
  - Giới tính (Gender)  
  - Ngày sinh (BirthDate)  
  - Địa chỉ (Address)  
  - Ảnh đại diện (PhotoURL)  
  - Mã phòng ban (DepartmentID - Khóa ngoại)  

- **Người dùng (Users)**  
  - Mã người dùng (UserID)  
  - Tên đăng nhập (Username - Duy nhất)  
  - Mật khẩu (PasswordHash - Được băm bằng BCrypt)  
  - Vai trò (Role: `Admin`, `User`)  


**2. Tạo DbContext dựa trên CSDL**  
- Sử dụng **Entity Framework Core** để quản lý kết nối và truy vấn CSDL.  
- DbContext chứa các DbSet cho các bảng trong CSDL.  


**3. Xây dựng các chức năng quản lý phòng ban và sinh viên**  
- **Thêm mới**  
- **Chỉnh sửa**  
- **Xóa**  
- **Hiển thị danh sách**  

**4. Chức năng tìm kiếm sinh viên**  
- Cho phép tìm kiếm sinh viên theo các tiêu chí:  
  - Mã sinh viên  
  - Họ tên  
  - Giới tính  
  - Địa chỉ  
  - Phòng ban  

**5. Chức năng đăng nhập và phân quyền**  
- **Sử dụng Form Authentication để xác thực người dùng.**  
- **Mật khẩu được băm bằng BCrypt trước khi lưu vào CSDL.**  
- **Phân quyền:**
  - `Admin`: Quản lý sinh viên, phòng ban, người dùng.  
  - `User`: Chỉ xem thông tin sinh viên.  

**6. Chức năng quản trị hệ thống**  
- **Quản lý tài khoản người dùng:**  
  - Thêm mới  
  - Chỉnh sửa
  - Xóa  
  - Đổi mật khẩu
- **Chỉ tài khoản có vai trò `Admin` mới được thực hiện.**