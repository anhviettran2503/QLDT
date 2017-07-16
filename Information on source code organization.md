# **THÔNG TIN VỀ TỔ CHỨC MÃ NGUỒN**

<img src="http://i.imgur.com/5CHmqxd.png">

## Mã nguồn được chia làm 3 tầng:GUI, BLL, DAL. Tầng DTO dùng để vận chuyển dữ liệu giữa các tầng.

<img src="http://i.imgur.com/3FYIi2g.png">

## -Phần mềm hoạt động theo hai cách:

### +CácH thông thường: Tất cả hoạt động ở GUI.

++File DB.cs chứa SQLConnection

++Fmain.cs là form chính

++FLogin.cs là form đăng nhập.

++Các form còn lại quản lý các chức năng của phần mềm

### +Cách tổ chức theo mô hình 3 lớp: 
++Tầng GUI thực hiện việc thao tác với người dùng.

++Tầng BLL thực hiện việc thao tác xử lý trong phần mềm.

++Tầng DAL thực hiện việc thao tác với SQL Server.

++Tầng DTO thực hiện việc đóng gói và vận chuyển dữ liệu vừa các tầng.


