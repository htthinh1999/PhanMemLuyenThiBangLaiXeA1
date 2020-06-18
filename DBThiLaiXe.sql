USE master
GO
IF  EXISTS (SELECT * FROM sys.databases WHERE name = 'BTLThiLaiXe')
    BEGIN
        DROP DATABASE BTLThiLaiXe
    END
GO
CREATE DATABASE BTLThiLaiXe
GO
use BTLThiLaiXe
go

create table Phan
(
	MaPhan smallint not null primary key,
	TenPhan nvarchar(20) not null,
)
create table CauHoi
(
	MaCauHoi varchar(3) not null primary key,
	NDCauHoi nvarchar(500) not null,
	MaPhan	smallint not null references Phan,
	Hinh varchar(20) not null,
)

create table DapAn
(
	MaCauTraLoi int not null,
	NDCauTraLoi nvarchar(300) not null,
	MaCauHoi varchar(3) not null,
	DungSai bit not null,
	primary key(MaCauTraLoi,NDCauTraLoi),
	foreign key (MaCauHoi) references CauHoi(MaCauHoi)
)
 

create table TaiKhoan
(
	Username varchar(20) not null primary key ,
	Password varchar(20) not null,
	IsAdmin bit not null
)

create table ThiSinh
(
	MaThiSinh varchar(10) not null primary key,
	HoTenThiSinh nvarchar(50) not null,
	NgaySinh date not null,
	GioiTinh char(1) default 'M',
	DiaChi nvarchar(50),
	Username varchar(20) not null,
	foreign key (Username) references TaiKhoan(Username)
)

create table KetQua
(
	STT int identity(1,1) primary key,
	MaThiSinh varchar(10) not null,
	ThoiGian datetime not null,
	LanThi int not null,
	KetQua varchar(5) not null,
	foreign key (MaThiSinh) references ThiSinh(MaThiSinh)
)

insert into Phan values(1,N'Giao thông đường bộ')

insert into Phan values(2,N'Biển báo')

insert into Phan values(3,N'Sa hình')

insert into CauHoi values('001', N'Khái niệm “đường bộ” được hiểu như thế nào là đúng?“Đường bộ” gồm:',1,'')

insert into CauHoi values('002', N'“Vạch kẻ đường” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('003', N'Khái niệm “phần đường xe chạy” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('004', N'Khái niệm “làn đường” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('005', N'Khái niệm “đường phố” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('006', N'Khái niệm “dải phân cách” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('007', N'Dải phân cách trên đường bộ có những loại nào?',1,'')

insert into CauHoi values('008', N'Khái niệm “đường ưu tiên” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('009', N'“Phương tiện giao thông đường bộ” gồm những loại nào?',1,'')

insert into CauHoi values('010', N'Khái niệm “phương tiện giao thông cơ giới đường bộ” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('011', N'“Phương tiện tham gia giao thông đường bộ” gồm những loại nào?',1,'')

insert into CauHoi values('012', N'“Người tham gia giao thông đường bộ” gồm những đối tượng nào?',1,'')

insert into CauHoi values('013', N'Khái niệm “người điều khiển giao thông” được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('014', N'Hành vi nào ghi ở dưới đây bị nghiêm cấm?',1,'')

insert into CauHoi values('015', N'Những hành vi nào ghi ở dưới đây bị nghiêm cấm?',1,'')

insert into CauHoi values('016', N'Người điều khiển phương tiện giao thông đường bộ mà trong cơ thể có chất ma túy có bị nghiêm cấm hay không?',1,'')

insert into CauHoi values('017', N' Người điều khiển xe ô tô, xe máy kéo, xe máy chuyên dùng trên đường mà trong máu hoặc hơi thở có nồng độ cồn vượt quá bao nhiêu thì bị cấm?',1,'')

insert into CauHoi values('018', N'Người điều khiển xe mô tô, xe gắn máy trên đường mà trong máu có nồng độ cồn vượt quá bao nhiêu thì bị cấm?',1,'')

insert into CauHoi values('019', N'Người điều khiển xe mô tô, xe gắn máy trên đường mà trong khí thở có nồng độ cồn vượt quá bao nhiêu thì bị cấm ?',1,'')

insert into CauHoi values('020', N'Hành vi giao xe cơ giới, xe máy chuyên dùng cho người không đủ điều kiện để điều khiển xe tham gia giao thông có bị nghiêm cấm hay không?',1,'')

insert into CauHoi values('021', N'Hành vi điều khiển xe cơ giới chạy quá tốc độ quy định, giành đường, vượt ẩu có bị nghiêm cấm hay không?',1,'')

insert into CauHoi values('022', N'Những hành vi nào sau đây bị cấm?',1,'')

insert into CauHoi values('023', N'Các hành vi nào sau đây bị nghiêm cấm?',1,'')

insert into CauHoi values('024', N'Hành vi bỏ trốn sau khi gây tai nạn để trốn tránh trách nhiệm hoặc khi có điều kiện mà cố ý không cứu giúp người bị tai nạn giao thông có bị nghiêm cấm hay không?',1,'')

insert into CauHoi values('025', N'Khi xảy ra tai nạn giao thông, những hành vi nào ghi ở dưới đây bị nghiêm cấm?',1,'')

insert into CauHoi values('026', N'Việc sản xuất, mua bán, sử dụng biển xe cơ giới, xe máy chuyên dùng được quy định như thế nào trong Luật giao thông đường bộ ?',1,'')

insert into CauHoi values('027', N'Người lái xe không được vượt xe khác khi gặp trường hợp nào ghi ở dưới đây?',1,'')

insert into CauHoi values('028', N'Người điều khiển xe mô tô hai bánh, ba bánh, xe gắn máy có được phép sử dụng xe để kéo, đẩy các xe khác, vật khác khi tham gia giao thông không?',1,'')

insert into CauHoi values('029', N'Người ngồi trên xe mô tô hai bánh, ba bánh, xe gắn máy khi tham gia giao thông không được thực hiện những hành vi nào sau đây?',1,'')

insert into CauHoi values('030', N'Người ngồi trên xe mô tô hai bánh, xe mô tô ba bánh, xe gắn máy khi tham gia giao thông có được mang, vác vật cồng kềnh hay không?',1,'')

insert into CauHoi values('031', N'Khi điều khiển xe mô tô hai bánh, mô tô ba bánh, xe gắn máy những hành vi nào không được phép?',1,'')

insert into CauHoi values('032', N'Bảo đảm trật tự an toàn giao thông đường bộ là trách nhiệm của ai?',1,'')

insert into CauHoi values('033', N'Tại nơi đường giao nhau, khi đèn điều khiển giao thông có tín hiệu vàng, người điều khiển phương tiện như thế nào?',1,'')

insert into CauHoi values('034', N'Biển báo hiệu đường bộ gồm những nhóm nào, ý nghĩa của từng nhóm?',1,'')

insert into CauHoi values('035', N'Tại nơi đường giao nhau, khi người điều khiển giao thông ra hiệu lệnh bằng hai tay hoặc một tay giang ngang để báo hiệu thì người tham gia giao thông phải đi như thế nào là đúng quy tắc giao thông?',1,'')

insert into CauHoi values('036', N'Tại nơi đường giao nhau, khi người điều khiển giao thông ra hiệu lệnh tay giơ thẳng đứng để báo hiệu thì người tham gia giao thông phải đi như thế nào?',1,'')

insert into CauHoi values('037', N'Tại nơi đường giao nhau, khi người điều khiển giao thông ra hiệu lệnh bằng tay phải giơ về phía trước để báo hiệu thì người tham gia giao thông phải đi như thế nào?',1,'')

insert into CauHoi values('038', N'Trên đường giao thông, khi hiệu lệnh của người điều khiển giao thông trái với hiệu lệnh của đèn hoặc biển báo hiệu thì người tham gia giao thông phải chấp hành theo hiệu lệnh nào?',1,'')

insert into CauHoi values('039', N'Tại nơi có biển báo hiệu cố định lại có báo hiệu tạm thời thì người tham gia giao thông phải chấp hành hiệu lệnh của báo hiệu nào?',1,'')

insert into CauHoi values('040', N'Trên đường có nhiều làn đường cho xe đi cùng chiều được phân biệt bằng vạch kẻ phân làn đường, người điều khiển phương tiện phải cho xe đi như thế nào?',1,'')

insert into CauHoi values('041', N'Trên đường một chiều có vạch kẻ phân làn đường, xe thô sơ và xe cơ giới phải đi như thế nào là đúng quy tắc giao thông?',1,'')

insert into CauHoi values('042', N'Trên đường có nhiều làn đường, người điều khiển phương tiện tham gia giao thông sử dụng làn đường như thế nào là đúng?',1,'')

insert into CauHoi values('043', N'Xe sau có thể vượt lên bên phải xe khác đang chạy phía trước trong trường hợp nào?',1,'')

insert into CauHoi values('044', N'Người lái xe phải làm gì khi quay đầu xe trên cầu,gầm cầu vượt, đường ngầm hay khu vực đường bộ giao nhau cùng mức với đường sắt?',1,'')

insert into CauHoi values('045', N'Khi muốn chuyển hướng, người lái xe phải thực hiện như thế nào?',1,'')

insert into CauHoi values('046', N'Khi tránh xe đi ngược chiều, các xe phải nhường đường nhe thế nào là đúng?',1,'')

insert into CauHoi values('047', N'Ban đêm xe cơ giới đi ngược chiều gặp nhau, đèn chiếu sáng phải sử dụng như thế nào?',1,'')

insert into CauHoi values('048', N'Khi có tín hiệu của xe ưu tiên, người tham gia giao thông phải làm gì?',1,'')

insert into CauHoi values('049', N'Tại nơi đường giao nhau có báo hiệu đi theo vòng xuyến người điều khiển phương tiện phải nhường đường như thế nào?',1,'')

insert into CauHoi values('050', N'Tại nơi đường giao nhau, người lái xe đang đi trên đường không ưu tiên phải nhường đường như thế nào?',1,'')

insert into CauHoi values('051', N'Tại nơi đường giao nhau không có báo hiệu đi theo vòng xuyến, người điều khiển phương tiện phải nhường đường như thế nào là đúng quy tắc giao thông?',1,'')

insert into CauHoi values('052', N'Trên đoạn đường bộ giao nhau cùng mức với đường sắt, cầu đường bộ đi chung với đường sắt thì loại phương tiện nào được quyền ưu tiên đi trước?',1,'')

insert into CauHoi values('053', N'Tại nơi đường bộ giao nhau cùng mức với đường sắt chỉ có đèn tín hiệu hoặc chuông báo hiệu, khi đèn tín hiệu màu đỏ đã bật sáng hoặc có tiếng chuông báo hiệu, người tham gia giao thông phải dừng lại ngay và giữ khoảng cách tối thiểu bao nhiêu mét tính từ ray gần nhất?',1,'')

insert into CauHoi values('054', N'Người lái xe phải làm gì khi điều khiển xe vào đường cao tốc?',1,'')

insert into CauHoi values('055', N'Người lái xe phải làm gì khi điều khiển xe ra khỏi làn đường cao tốc?',1,'')

insert into CauHoi values('056', N'Những trường hợp nào ghi ở dưới đây không được đi vào đường cao tốc trừ người, phương tiện, thiết bị phục vụ cho việc quản lí, bảo trì đường cao tốc?',1,'')

insert into CauHoi values('057', N'Người điều khiển phương tiện tham gia giao thông trong hầm đường bộ ngoài việc phải tuân thủ các quy tắc giao thông còn phải thực hiện những quy định nào ghi ở dưới đây?',1,'')

insert into CauHoi values('058', N'Người ngồi trên xe mô tô 2 bánh, xe mô tô 3 bánh, xe gắn máy phải đội mũ bảo hiểm có cài quay đúng quy cách khi nào?',1,'')

insert into CauHoi values('059', N'Khi điều khiển xe mô tô 2 bánh, xe gắn máy được phép chở tối đa 2 người trong những trường hợp nào?',1,'')

insert into CauHoi values('060', N'Người điều khiển xe mô tô 2 bánh, xe mô tô 3 bánh, xe gắn máy không được thực hiện những hành vi nào ghi ở dưới đây?',1,'')

insert into CauHoi values('061', N'Người điều khiển, người ngồi trên xe đạp máy phải đội mũ bảo hiểm có cài quay đúng quy cách khi nào?',1,'')

insert into CauHoi values('062', N'Cơ quan nào quy định các đoạn đường cấm đi, đường đi một chiều, nơi cấm dừng, cấm đỗ, cấm quay đầu xe, lắp đặt báo hiệu đường bộ thuộc địa phương quản lí?',1,'')

insert into CauHoi values('063', N'Người điều khiển phương tiện và những người liên quan trực tiếp đến vụ tai nạn có trách nhiệm gì?',1,'')

insert into CauHoi values('064', N'Những người có mặt tại nơi xảy ra tai nạn giao thông có trách nhiệm gì?',1,'')

insert into CauHoi values('065', N'Khi điều khiển xe chạy trên đường, người lái xe phải mang theo các loại giấy tờ gì?',1,'')

insert into CauHoi values('066', N'Người đủ bao nhiêu tuổi trở lên thì được điều khiển xe mô tô 2 bánh, xe mô tô 3 bánh có dung tích xilanh từ 50 cm3 trở lên và các loại xe có kết cấu tương tự, xe ô tô tải, máy kéo có trọng tải dưới 3,5 tấn; xe ô tô chở người dưới 9 chỗ ngồi?',1,'')

insert into CauHoi values('067', N'Tại ngã ba hoặc ngã tư không có đảo an toàn, người lái xe phải nhường đường như thế nào là đúng trong các trường hợp dưới đây?',1,'')

insert into CauHoi values('068', N'Người đủ 16 tuổi được điều khiển các loại xe nào dưới đây?',1,'')

insert into CauHoi values('069', N'Khi phát hiện hành vi giả khai báo mất hoặc tẩy xóa, làm sai lệch các thông tin trên giấy phép lái xe; sử dụng giấy phép lái xe hoặc đổi hồ sơ giả; có hành vi cố tình gian dối để được đổi, cấp mới, cấp lại giấy phép lái xe, ngoài việc bị cơ quan quản lý giấy phép lái xe quyết định thu hồi giấy phép lái xe và hồ sơ gốc còn phải chịu trách nhiệm trước pháp luật, người lái xe không được cấp giấy phép lái xe trong thời gian bao nhiêu năm??',1,'')

insert into CauHoi values('070', N'Người lái xe mô tô xử lý như thế nào khi cho xe mô tô phía sau vượt?',1,'')

insert into CauHoi values('071', N'Trong các trường hợp dưới đây, để đảm bảo an toàn khi tham gia giao thông, người lái xe mô tô cần thực hiện như thế nào?',1,'')

insert into CauHoi values('072', N'Đường bộ trong khu vực đông dân cư gồm những đường nào?',1,'')

insert into CauHoi values('073', N'Trên đường bộ trong khu vực đông dân cư, xe mô tô hai bánh, xe gắn máy tham gia giao thông với tốc độ tối đa cho phép là bao nhiêu?',1,'')

insert into CauHoi values('074', N'Trên đường bộ trong khu vực đông dân cư, loại xe nào tham gia giao thông với tốc độ tối đa cho phép là 40 km/h?',1,'')

insert into CauHoi values('075', N'Trên đường bộ ngoài khu đông dân cư, loại xe nào tham gia giao thông với tốc độ tối đa cho phép là 50 km/h?',1,'')

insert into CauHoi values('076', N'Khái niệm về văn hóa giao thông được hiểu như thế nào là đúng?',1,'')

insert into CauHoi values('077', N'Người lái xe cố tình vi phạm Luật giao thông đường bộ, không phân biệt làn đường, vạch phân làn, phóng nhanh, vượt ẩu, vượt đèn đỏ, đi vào đường cấm, đường một chiều được coi là hành vi nào trong các hành vi sau đây?',1,'')

insert into CauHoi values('078', N'Trong các hành vi dưới đây, người lái xe mô tô có văn hóa giao thông phải ứng xử như thế nào?',1,'')

insert into CauHoi values('079', N'Trong các hành vi dưới đây, người lái xe mô tô có văn hóa giao thông phải ứng xử như thế nào?',1,'')

insert into CauHoi values('080', N'Người có văn hóa giao thông, khi điều khiển xe cơ giới tham gia giao thông đường bộ phải đảm bảo các điều kiện gì?',1,'')

insert into CauHoi values('081', N'Biển nào cấm người đi bộ?',2,'81')

insert into CauHoi values('082', N'Gặp biển nào người lái xe phải nhường đường cho người đi bộ?',2,'82')

insert into CauHoi values('083', N'Biển nào chỉ đường dành cho người đi bộ, các loại xe không được đi vào khi gặp biển này?',2,'83')

insert into CauHoi values('084', N' Biển nào báo hiệu sắp đến chỗ giao nhau nguy hiểm?',2,'84')

insert into CauHoi values('085', N'Biển nào báo hiệu sắp đến chỗ giao nhau với đường sắt có rào chắn?',2,'85')

insert into CauHoi values('086', N'Biển nào báo hiệu giao nhau có tín hiệu đèn?',2,'86')

insert into CauHoi values('087', N'Biển nào báo hiệu nguy hiểm giao nhau với đường sắt?',2,'87')

insert into CauHoi values('088', N'Biển nào báo hiệu đường sắt giao nhau với đường bộ không có rào chắn?',2,'88')

insert into CauHoi values('089', N'Biển nào báo hiệu “Hết đoạn đường ưu tiên”?',2,'89')

insert into CauHoi values('090', N'Biển nào báo hiệu, chỉ dẫn xe đi trên đường này được quyền ưu tiên qua nơi giao nhau?',2,'90')

insert into CauHoi values('091', N'Biển nào báo hiệu giao nhau với đường không ưu tiên?',2,'91')

insert into CauHoi values('092', N'Biển nào báo hiệu giao nhau với đường ưu tiên?',2,'92')

insert into CauHoi values('093', N'Biển nào báo hiệu giao nhau với đường ưu tiên?',2,'93')

insert into CauHoi values('094', N'Biển nào báo hiệu “Đường giao nhau” của các tuyến đường cùng cấp?',2,'94')

insert into CauHoi values('095', N'Biển nào báo hiệu giao nhau với đường không ưu tiên?',2,'95')

insert into CauHoi values('096', N'Biển nào báo hiệu đường hai chiều?',2,'96')

insert into CauHoi values('097', N'Biển nào báo hiệu phải giảm tốc độ, nhường đường cho xe cơ giới đi ngược chiều qua đường hẹp?',2,'97')

insert into CauHoi values('098', N'Biển nào chỉ dẫn được ưu tiên qua đường hẹp?',2,'98')

insert into CauHoi values('099', N'Biển nào báo hiệu cấm xe mô tô ba bánh đi vào?',2,'99')

insert into CauHoi values('100', N'Biển nào báo hiệu cấm xe mô tô hai bánh đi vào?',2,'100')

insert into CauHoi values('101', N'Khai gặp biển nào thì xe mô tô hai bánh được đi vào?',2,'101')

insert into CauHoi values('102', N'Biển nào xe mô tô hai bánh được đi vào?',2,'102')

insert into CauHoi values('103', N'Biển nào xe mô tô hai bánh không được đi vào?',2,'103')

insert into CauHoi values('104', N'Ba biển này có ý nghĩa hiệu lực như thế nào?',2,'104')

insert into CauHoi values('105', N'Biển nào cấm quay xe?',2,'105')

insert into CauHoi values('106', N'Biển nào cấm xe rẽ trái?',2,'106')

insert into CauHoi values('107', N'Khi gặp biển nào xe được rẽ trái?',2,'107')

insert into CauHoi values('108', N'Khi gặp biển nào xe ưu tiên theo luật định vẫn phải dừng lại?',2,'108')

insert into CauHoi values('109', N'Khi đến chỗ giao nhau, gặp biển nào thì người lái xe không được cho xe đi thẳng, phải rẽ sang hướng khác?',2,'109')

insert into CauHoi values('110', N'Khi gặp biển này, xe lam và mô tô ba bánh có được phép rẽ trái hay rẽ phải hay không?',2,'110')

insert into CauHoi values('111', N'Biển này có hiệu lực đối với xe mô tô hai, ba bánh không?',2,'111')

insert into CauHoi values('112', N'Biển nào báo hiệu cầu vượt liên thông?',2,'112')

insert into CauHoi values('113', N'Biển nào báo hiệu đoạn đường hay xảy ra tai nạn?',2,'113')

insert into CauHoi values('114', N' Biển nào báo hiệu tuyến đường cầu vượt cắt qua?',2,'114')

insert into CauHoi values('115', N'Biển nào chỉ dẫn tên đường trên các tuyến đường đối ngoại?',2,'115')

insert into CauHoi values('116', N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông?',3,'116')

insert into CauHoi values('117', N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông?',3,'117')

insert into CauHoi values('118', N'Trường hợp này xe nào được quyền đi trước?',3,'118')

insert into CauHoi values('119', N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông?',3,'119')

insert into CauHoi values('120', N'Xe nào được quyền đi trước trong trường hợp này?',3,'120')

insert into CauHoi values('121', N'Theo tín hiệu đèn, xe nào được phép đi?',3,'121')

insert into CauHoi values('122', N'Theo tín hiệu đèn, xe nào được quyền đi là đúng quy tắc giao thông?',3,'122')

insert into CauHoi values('123', N'Các xe đi theo mũi tên, xe nào vi phạm quy tắc giao thông?',3,'123')

insert into CauHoi values('124', N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông?',3,'124')

insert into CauHoi values('125', N'Trong trường hợp này xe nào đỗ vi phạm quy tắc giao thông?',3,'125')

insert into CauHoi values('126', N'Xe nào được quyền đi trước?',3,'126')

insert into CauHoi values('127', N'Theo mũi tên, những hướng nào xe gắn máy đi được?',3,'127')

insert into CauHoi values('128', N'Xe nào đỗ vi phạm quy tắc giao thông?',3,'128')

insert into CauHoi values('129', N'Xe nào đỗ vi phạm quy tắc giao thông?',3,'129')

insert into CauHoi values('130', N'Xe tải kéo mô tô ba bánh như hình này có đúng quy tắc giao thông không?',3,'130')

insert into CauHoi values('131', N'Xe nào được quyền đi trước trong trường hợp này?',3,'131')

insert into CauHoi values('132', N'Thứ tự các xe đi như thế nào là đúng quy tắc giao thông?',3,'132')

insert into CauHoi values('133', N'Xe nào được quyền đi trước trong trường hợp này?',3,'133')

insert into CauHoi values('134', N'Xe nào vi phạm quy tắc giao thông?',3,'134')

insert into CauHoi values('135', N'Các xe đi như thế nào là đúng quy tắc giao thông?',3,'135')

insert into CauHoi values('136', N'Theo hướng mũi tên, xe nào được phép đi?',3,'136')

insert into CauHoi values('137', N'Trong hình dưới đây, xe nào chấp hành đúng quy tắc giao thông?',3,'137')

insert into CauHoi values('138', N'Theo hướng mũi tên, những hướng nào xe mô tô được phép đi.',3,'138')

insert into CauHoi values('139', N'Trong trường hợp này, thứ tự các xe đi như thế nào là đúng quy tắc giao thông?',3,'139')

insert into CauHoi values('140', N'Trong hình dưới, những xe nào vi phạm quy tắc giao thông?',3,'140')

insert into CauHoi values('141', N'Trong hình dưới, những xe nào vi phạm quy tắc giao thông?',3,'141')

insert into CauHoi values('142', N'Theo tín hiệu đèn, xe nào phải dừng lại là đúng quy tắc giao thông?',3,'142')

insert into CauHoi values('143', N'Bạn có được phép vượt xe mô tô phía trước không?',3,'143')

insert into CauHoi values('144', N'Theo tín hiệu đèn của xe cơ giới, xe nào vi phạm quy tắc giao thông?',3,'144')

insert into CauHoi values('145', N'Các xe đi theo hướng mũi tên, xe nào vi phạm quy tắc giao thông?',3,'145')

insert into CauHoi values('146', N'Các xe đi theo hướng mũi tên, xe nào vi phạm quy tắc giao thông?',3,'146')

insert into CauHoi values('147', N'Các xe đi theo hướng mũi tên, xe nào vi phạm quy tắc giao thông?',3,'147')

insert into CauHoi values('148', N' Các xe đi theo hướng mũi tên, xe nào chấp hành đúng quy tắc giao thông?',3,'148')

insert into CauHoi values('149', N'Các xe đi theo thứ tự nào là đúng quy tắc giao thông đường bộ?',3,'149')

insert into CauHoi values('150', N' Các xe đi theo thứ tự nào là đúng quy tắc giao thông đường bộ?',3,'150')

/* insert into Đáp án*/

insert into DapAn values('001',N'1.Đường bộ, cầu đường bộ.','001',1)

insert into DapAn values('002',N'2.Hầm đường bộ, bến phà đường bộ.','001',1)

insert into DapAn values('003',N'3.Đường, cầu đường bộ, hầm đường bộ, bến phà đường bộ và các công trình phụ trợ khác.','001',0)

insert into DapAn values('004',N'1.Vạch kẻ đường là vạch chỉ sự phân chia làn đường, vị trí hoặc hướng đi, vị trí dừng lại.','002',1)

insert into DapAn values('005',N'2.Vạch kẻ đường là vạch chỉ sự phân biệt trí dừng, đỗ trên đường.','002',0)

insert into DapAn values('006',N'3.Tất cả các ý nêu trên.','002',0)

insert into DapAn values('007',N'1.Là phần của đường bộ được sử dụng cho các phương tiện giao thông qua lại.','003',1)

insert into DapAn values('008',N'2.Là phần đường bộ được sử dụng cho các phương tiện giao thông qua lại, dải đất dọc hai bên đường để đảm bảo an toàn giao thông.','003',0)

insert into DapAn values('009',N'3.Là phần đường bộ được sử dụng cho các phương tiện giao thông qua lại, các công trình, thiết bị phụ trợ khác và dải đất dọc hai bên đường để đảm bảo an toàn giao thông.','003',0)

insert into DapAn values('010',N'1.Là một phần của đường được chia theo chiều ngang của đường, có bề rộng đủ cho xe đỗ an toàn.','004',0)

insert into DapAn values('011',N'2.Là một phần đường xe chạy được chia theo chiều dọc của đường, có bề rộng đủ cho xe chạy an toàn.','004',1)

insert into DapAn values('012',N'3.Cả 02 ý trên.','004',0)

insert into DapAn values('013',N'1.Đường phố là đường đô thị, gồm lòng đường và hè phố.','005',1)

insert into DapAn values('014',N'2.Đường phố là đường bộ ngoài đô thị có lòng đường đủ rộng cho các phương tiện giao thông qua lại','005',0)

insert into DapAn values('015',N'3.Cả 02 ý nêu trên.','005',0)

insert into DapAn values('016',N'1.Là bộ phận của đường để phân chia mặt đường thành hai chiều xe chạy riêng biệt hoặc để phân chia phần đường của xe cơ giới và xe thô sơ.','006',1)

insert into DapAn values('017',N'2.Là bộ phận của đường để xác định ranh giới của đất dành cho người đi bộ theo chiều ngang của đường.','006',0)

insert into DapAn values('018',N'3.Là bộ phận của đường để ngăn cách không cho các loại xe vào những nơi không được phép.','006',0)

insert into DapAn values('019',N'1.Loại cố định.','007',1)

insert into DapAn values('020',N'2.Loại di động.','007',1)

insert into DapAn values('021',N'1Đường ưu tiên là đường mà trên đó phương tiện tham gia giao thông đường bộ phải nhường đường cho các phương tiện đến từ hướng khác khi qua nơi đường giao nhau, có thể được cắm biển báo hiệu đường ưu tiên..','008',0)

insert into DapAn values('022',N'2.Đường ưu tiên là đường mà trên đó phương tiện tham gia giao thông đường bộ được các phương tiện đến từ hướng khác nhường đường khi qua nơi đường giao nhau, được cắm biển báo hiệu đường ưu tiên.','008',1)

insert into DapAn values('023',N'3.Đường ưu tiên là đường chỉ dành cho một số loại phương tiện tham gia giao thông, được cắm biển báo hiệu đường ưu tiên.','008',0)

insert into DapAn values('024',N'1.Phương tiện giao thông cơ giới đường bộ, phương tiện giao thông thô sơ đường bộ.','009',1)

insert into DapAn values('025',N'2.Phương tiện giao thông thô sơ đường bộ, phương tiện giao thông cơ giới đường bộ và xe máy chuyên dùng.','009',0)

insert into DapAn values('026',N'3.Cả 2 ý trên.','009',0)

insert into DapAn values('027',N'1.Gồm xe ô tô, máy kéo, xe mô tô hai bánh, xe mô tô ba bánh, xe gắn máy, xe cơ giới dành cho người khuyết tật và xe máy chuyên dùng.','010',0)

insert into DapAn values('028',N'2.Gồm xe ô tô, máy kéo, rơ moóc hoặc sơ mi rơ moóc được kéo bởi xe ô tô, máy kéo, xe mô tô hai bánh, xe mô tô ba bánh, xe gắn máy (kể cả xe máy điện) và các loại xe tương tự.','010',1)

insert into DapAn values('029',N'1.Phương tiện giao thông cơ giới đường bộ.','011',1)

insert into DapAn values('030',N'2.Phương tiện giao thông thô sơ đường bộ và xe máy chuyên dùng.','011',1)

insert into DapAn values('031',N'1.Người điều khiển, người sử dụng phương tiện tham gia giao thông đường bộ.','012',1)

insert into DapAn values('032',N'2.Người điều khiển, dẫn dắt súc vật, người đi bộ trên đường bộ.','012',1)

insert into DapAn values('033',N'1.Là người điều khiển phương tiện tham gia giao thông.','013',0)

insert into DapAn values('034',N'2.Là người được giao nhiệm vụ hướng dẫn giao thông tại nơi thi công, nơi ùn tắc giao thông, ở bến phà, tại cầu đường bộ đi chung với đường sắt.','013',1)

insert into DapAn values('035',N'3.Là cảnh sát giao thông.','013',1)

insert into DapAn values('036',N'4.Tất cả các ý nêu trên.','013',0)

insert into DapAn values('037',N'1.Phá hoại đường, cầu, hầm, bến phà đường bộ, phá hoại đèn tín hiệu, cọc tiêu, biển báo hiệu, gương cầu, dải phân cách.','014',1)

insert into DapAn values('038',N'2.Phá hoại hệ thống thoát nước và các công trình, thiết bị khác thuộc kết cấu hạ tầng giao thông đường bộ.','014',1)

insert into DapAn values('039',N'1.Đua xe, cổ vũ đua xe, tổ chức đua xe trái phép.','015',1)

insert into DapAn values('040',N'2.Lạng lách, đánh võng.','015',1)

insert into DapAn values('041',N'1.Bị nghiêm cấm..','016',1)

insert into DapAn values('042',N'2.Không Bị nghiêm cấm.','016',0)

insert into DapAn values('043',N'1.Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng mà trong máu có nồng độ cồn vượt quá 50 miligam/100 mililit máu hoặc 0.25 miligam/1 lit khí thở.','017',0)

insert into DapAn values('044',N'2.Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng trên đường mà trong máu hoặc hơi thở có nồng độ cồn.','017',1)

insert into DapAn values('045',N'3.Người điều khiển xe ô tô, máy kéo, xe máy chuyên dùng trên đường mà trong máu có nồng độ cồn vượt quá 80 miligam/100 mililit máu hoặc 40 miligam/1 lit khí thở.','017',0)

insert into DapAn values('046',N'1.Nồng độ cồn vượt quá 50 miligam/100 mililit máu.','018',1)

insert into DapAn values('047',N'2.Nồng độ cồn vượt quá 40 miligam/100 mililit máu.','018',0)

insert into DapAn values('048',N'3.Nồng độ cồn vượt quá 30 miligam/100 mililit máu.','018',0)

insert into DapAn values('049',N'1.Nồng độ cồn vượt quá 0.25 miligam/1 lit khí thở.','019',1)

insert into DapAn values('050',N'2.Nồng độ cồn vượt quá 0.20 miligam/1 lit khí thở.','019',0)

insert into DapAn values('051',N'3.Nồng độ cồn vượt quá 0.15 miligam/1 lit khí thở.','019',0)

insert into DapAn values('052',N'1.Không bị nghiêm cấm.','020',0)

insert into DapAn values('053',N'2.Bị nghiêm cấm.','020',1)

insert into DapAn values('054',N'3.Nghiêm cấm tùy từng trường hợp.','020',0)

insert into DapAn values('055',N'1.Không bị nghiêm cấm.','021',1)

insert into DapAn values('056',N'2.Bị nghiêm cấm.','021',0)

insert into DapAn values('057',N'3.Nghiêm cấm tùy từng trường hợp.','021',0)

insert into DapAn values('058',N'1.Bấm còi, rú ga liên tục, bấm còi trong thời gian từ 22 giờ đến 5 giờ.','022',1)

insert into DapAn values('059',N'2.Bấm còi hơi, sử dụng đèn chiếu xa trong khu đô thị và khu dân cư, trừ các xe ưu tiên khi đang làm nhiệm vụ.','022',1)

insert into DapAn values('060',N'1.Lắp đặt, sử dụng còi, đèn không đúng thiết kế của nhà sản xuất đối với từng loại xe cơ giới.','023',1)

insert into DapAn values('061',N'2.Sử dụng thiết bị âm thanh gây mất trật tự an toàn giao thông, trật tự công cộng.','023',1)

insert into DapAn values('062',N'1.Không bị nghiêm cấm.','024',0)

insert into DapAn values('063',N'2.Nghiêm cấm tùy từng trường hợp cụ thể.','024',0)

insert into DapAn values('064',N'3.Bị nghiêm cấm.','024',1)

insert into DapAn values('065',N'1.Xâm phạm tính mạng, sức khỏe, tài sản của người bị tai nạn giao thông, xâm phạm tính mạng, sức khỏe, tài sản của người gây tai nạn giao thông.','025',1)

insert into DapAn values('066',N'2.Lợi dụng việc xảy ra tai nạn giao thông để hành hung, đe dọa, xúi giục, gây sức ép, làm mất trật tự, cản trở việc xử lý tai nạn giao thông.','025',1)

insert into DapAn values('067',N'1.Nghiêm cấm sản xuất, được phép sử dụng.','026',0)

insert into DapAn values('068',N'2.Nghiêm cấm mua bán,cho phép sử dụng.','026',0)

insert into DapAn values('069',N'3.Nghiêm cấm sản xuất, mua bán, sử dụng trái phép.','026',1)

insert into DapAn values('070',N'1.Trên cầu hẹp có một làn xe, nơi đường giao nhau, đường bộ giao nhau cùng mức với đường sắt.','027',1)

insert into DapAn values('071',N'2.Điều kiện thời tiết hoặc đường không đảm bảo an toàn cho việc vượt, xe ưu tiên đang phát tín hiệu ưu tiên làm nhiệm vụ.','027',1)

insert into DapAn values('072',N'1.Được phép.','028',0)

insert into DapAn values('073',N'2.Tùy trường hợp.','028',0)

insert into DapAn values('074',N'3.Không được phép.','028',1)

insert into DapAn values('075',N'1.Đội mũ bảo hiểm và cài quai đúng cách.','029',0)

insert into DapAn values('076',N'2.Sử dụng ô; bấm, kéo hoặc đẩy các phương tiện khác.','029',1)

insert into DapAn values('077',N'3.Đứng trên yên, giá đèo hàng hoặc ngồi trên tay lái, các hành vi khác gây mất trật tự an toàn giao thông.','029',1)

insert into DapAn values('078',N'1.Được mang, vác tùy trường hợp cụ thể.','030',0)

insert into DapAn values('079',N'2.Không được mang, vác.','030',1)

insert into DapAn values('080',N'3.Được mang, vác nhưng phải đảm bảo an toàn.','030',0)

insert into DapAn values('081',N'1.Buông cả hai tay hoặc đi xe bằng một bánh đối với xe hai bánh, bằng hai bánh đối với xe ba bánh, chạy quá tốc độ quy định.','031',1)

insert into DapAn values('082',N'2.Sử dụng xe để kéo, đẩy xe khác, vật khác và chở vật cồng kềnh, để chân chống quẹt xuống đất và cá hành vi khác gây mất trật tự an toàn giao thông.','031',1)

insert into DapAn values('083',N'3.Chạy đúng tốc độ quy định và chấp hành đúng quy tắc giao thông đường bộ.','031',0)

insert into DapAn values('084',N'1.Là trách nhiệm của ngành giao thông vận tải và ngành công an.','032',0)

insert into DapAn values('085',N'2.Là trách nhiệm của cơ quan, tổ chức, cá nhân.','032',1)

insert into DapAn values('086',N'3.Là trách nhiệm của cảnh sát giao thông.','032',0)

insert into DapAn values('087',N'1.Phải cho xe dừng lại trước vạch dừng,trừ trường hợp đã đi quá vạch dừng thì được đi tiếp; trong trường hợp tín hiệu vàng nhấp nháy là được đi nhưng phải giảm tốc độ, chú ý quan sát, nhường đường cho người đi bộ qua đường.','033',1)

insert into DapAn values('088',N'2.Phải cho xe nhanh chóng vượt qua vạch dừng để đi qua đường giao nhau và chú ý đảm bảo an toàn; khi đèn tín hiệu vàng nhấp nháy là được đi nhưng phải giảm tốc độ, chú ý quan sát người đi bộ để đảm bảo an toàn.','033',0)

insert into DapAn values('089',N'3.Cả 2 ý nêu trên.','033',0)

insert into DapAn values('090',N'1.Nhóm biển báo cấm để biểu thị các điều cấm; nhóm biển báo hiệu nguy hiểm để cảnh báo các tình huống nguy hiểm có thể xảy ra, nhóm biển hiệu lệnh để báo hiệu các hiệu lệnh phải thi hành.','034',1)

insert into DapAn values('091',N'2.Nhóm biển chỉ dẫn để chỉ dẫn hướng đi hoặc các điều biết; nhóm biển phụ để thuyết minh bổ sung các loại biển báo cấm, biển báo nguy hiểm, biển hiệu lệnh và biển chỉ dẫn.','034',1)

insert into DapAn values('092',N'1.Người tham gia giao thông ở phía trước và ở phía sau người điều khiển giao thông phải dừng lại; người tham gia giao thông ở phía bên phải và bên trái người điều khiển được đi.','035',1)

insert into DapAn values('093',N'2.Người tham gia giao thông ở phía trước và ở phía sau người điều khiển giao thông được đi thẳng; người tham gia giao thông ở phía bên phải và bên trái người điều khiển giao thông được đi thẳng và rẽ phải.','035',0)

insert into DapAn values('094',N'1.Người tham gia giao thông ở phía trước và ở phía sau người điều khiển giao thông phải dừng lại, người tham gia giao thông ở phía bên phải và bên trái người điều khiển được đi..','036',0)

insert into DapAn values('095',N'2.Người tham gia giao thông ở các hướng phải dừng lại.','036',1)

insert into DapAn values('096',N'3.Tất cả các trường hợp trên.','036',0)

insert into DapAn values('097',N'1.Người tham gia giao thông ở phía sau người điều khiển phải dừng lại; người ở phía trước người điều khiển được rẽ trái; người ở bên trái người điều khiển được rẽ trái; người đi bộ qua đường phải dừng lại sau lưng người điều khiển giao thông.','037',0)

insert into DapAn values('098',N'2.Người tham giao giao thông ở phía sau và bên phải người điều khiển phải dừng lại; người ở phía trước người điều khiển được rẽ phải; người ở phía bên trái người điều khiển giao thông được đi tất cả các hướng; người đi bộ qua đường phải đi sau lưng người điều khiển giao thông.','037',1)

insert into DapAn values('099',N'1.Hiệu lệnh của người điều khiển giao thông.','038',1)

insert into DapAn values('100',N'2.Hiệu lệnh của đèn điều khiển giao thông.','038',0)

insert into DapAn values('101',N'3.Hiệu lệnh của biển báo hiệu đường bộ.','038',0)

insert into DapAn values('102',N'1.Biển báo hiệu cố định.','039',0)

insert into DapAn values('103',N'2.Báo hiệu tạm thời.','039',1)

insert into DapAn values('104',N'1.Cho xe đi trên bất kì làn đường nào,khi cần thiết phải chuyển làn đường, người lái xe phải có đèn tín hiệu báo trước và phải bảo đảm an toàn.','040',0)

insert into DapAn values('105',N'2.Phải cho xe đi trong một làn đường và chỉ được chuyển làn đường ở những nơi cho phép; khi chuyển làn phải có tín hiệu báo trước và phải đảm bảo an toàn.','040',1)

insert into DapAn values('106',N'3.Phải cho xe đi trong một làn, khi chuyển làn đường phải có tín hiệu báo trước, chú ý quan sát để bảo đảm an toàn.','040',0)

insert into DapAn values('107',N'1.Xe thô sơ phải đi làn đường bên trái trong cùng; xe cơ giới, xe máy chuyên dùng phải đi trên làn đường bên phải.','041',0)

insert into DapAn values('108',N'2.Xe thô sơ phải đi trên làn đường bên phải trong cùng, xe cơ giới, xe máy chuyên dùng phải đi trên làn đường bên trái.','041',1)

insert into DapAn values('109',N'3.Xe thô sơ phải đi trên làn đường phù hợp không gây cản trở giao thông, xe cơ giới, xe máy chuyên dùng đi trên làn đường bên phải','041',0)

insert into DapAn values('110',N'1.Trên đường có nhiều làn đường cho xe đi cùng chiều được phân biệt bằng vạch kẻ phân làn đường, người điều khiển phương tiện phải cho xe đi trong một làn đường và chỉ được chuyển làn đường ở những nơi cho phép ; khi chuyển làn đường phải có tín hiệu báo trước và đảm bảo an toàn.','042',1)

insert into DapAn values('111',N'2.Phương tiện tham gia giao thông đường bộ di chuyển tốc độ thấp hơn đi về bên trái.','042',0)

insert into DapAn values('112',N'3.Trên đường một chiều có vạch kẻ phân làn đường, xe thô sơ phải đi trên làn đường bên phải trong cùng xe cơ giới, xe máy chuyên dùng đi trên làn đường bên trái, phương tiện tham gia giao thông đường bộ di chuyển tốc độ thấp hơn đi về bên phải.','042',1)

insert into DapAn values('113',N'1.Khi xe phía trước có tín hiệu rẽ trái hoặc đang rẽ trái; khi xe điện đang chạy giữa đường.','043',1)

insert into DapAn values('114',N'2.Khi xe chuyên dùng đang làm việc trên đường mà không thể vượt bên trái được.','043',1)

insert into DapAn values('115',N'3.Khi có đủ khoảng trống để vượt xe.','043',1)

insert into DapAn values('116',N'1.Không được quay đầu xe.','044',1)

insert into DapAn values('117',N'2.Lợi dụng chỗ trống và phải có người làm tín hiệu sau xe để đảm bảo an toàn.','044',0)

insert into DapAn values('118',N'3.Lợi dụng chỗ trống có thể quay đầu được để quay đầu xe cho an toàn.','044',0)

insert into DapAn values('119',N'1.Người điều khiển phương tiện phải tăng tốc độ và có tín hiệu báo hướng để rẽ.','045',0)

insert into DapAn values('120',N'2.Người điều khiển phương tiện phải giảm tốc độ và có tín hiệu báo hướng rẽ, chỉ cho rẽ chuyển hướng khi quan sát thấy không gây trở ngại hoặc nguy hiểm cho người và phương tiện khác.','045',1)

insert into DapAn values('121',N'3.Trong khi chuyển hướng, người lái xe, người điều khiển xe máy chuyên dùng phải nhường quyền đi trước cho người đi bộ, người đi xe đạp đang đi trên phần đường dành riêng cho họ, nhường đường cho các xe đi ngược chiều.','045',1)

insert into DapAn values('122',N'1.Nơi đường hẹp chỉ đủ cho một xe chạy và có chỗ tránh xe thì xe nào ở gần chỗ tránh hơn phải vào vị trí tránh nhường đường cho xe kia đi.','046',1)

insert into DapAn values('123',N'2.Xe xuống dốc phải nhường đường cho xe đang lên dốc, xe nào có chướng ngại vật phía trước phải nhường đường cho xe không có chướng ngại vật đi trước.','046',1)

insert into DapAn values('124',N'3.Xe lên dốc phải nhường đường cho xe xuống dốc.','046',0)

insert into DapAn values('125',N'1.Phải chuyến từ đèn chiếu gần sang đèn chiếu xa.','047',0)

insert into DapAn values('126',N'2.Phải chuyển từ đèn chiếu xa sang đèn chiếu gần.','047',1)

insert into DapAn values('127',N'1.Phải nhanh chống giảm tốc độ, tránh hoặc dừng lại sát lề đường bên trái để nhường đường.','048',0)

insert into DapAn values('128',N'2.Phải nhanh chống tăng tốc độ, tránh sát lề đường để nhường đường cho xe ưu tiên. Cấm các hành vi gây cản trở xe ưu tiên.','048',0)

insert into DapAn values('129',N'3.Phải nhanh chống giảm tốc độ, tránh hoặc dừng lại sát lề đường bên phải để nhường đường. Không được gây cản trở xe được quyền ưu tiên.','048',1)

insert into DapAn values('130',N'1.Phải nhường đường cho xe đi bên phải.','049',0)

insert into DapAn values('131',N'2.Xe báo hiệu xin đường trước xe đó được đi trước.','049',0)

insert into DapAn values('132',N'3.Phải nhường đường cho xe đi bên trái.','049',1)

insert into DapAn values('133',N'1.Nhường đường cho xe đi ở bên phải mình tới.','050',0)

insert into DapAn values('134',N'2.Nhường đường cho xe đi ở bên trái mình tới.','050',0)

insert into DapAn values('135',N'3.Nhường đường cho xe đi trên đường ưu tiên hoặc đường chính đi từ bất kì hướng nào tới.','050',1)

insert into DapAn values('136',N'1.Phải nhường đường cho xe đi từ bên phải.','051',1)

insert into DapAn values('137',N'2.Xe báo hiệu xin đường trước xe đó được đi trước.','051',0)

insert into DapAn values('138',N'3.Phải nhường đường cho xe đi từ bên trái.','051',0)

insert into DapAn values('139',N'1.Phương tiện nào bên phải không vướng.','052',0)

insert into DapAn values('140',N'2.Phương tiện nào ra tín hiệu xin đường trước.','052',0)

insert into DapAn values('141',N'3.Phương tiện giao thông đường sắt.','052',1)

insert into DapAn values('142',N'1.5.00m.','053',1)

insert into DapAn values('143',N'2.3.00m.','053',0)

insert into DapAn values('144',N'3.4.00m.','053',0)

insert into DapAn values('145',N'4.7.00m.','053',0)

insert into DapAn values('146',N'1.Phải có tín hiệu xin vào và phải nhường đường cho xe đang chạy trên đường, khi thấy an toàn mới cho xe nhập vào dòng xe ở làn đường sát mép ngoài.','054',1)

insert into DapAn values('147',N'2.Phải có tín hiệu và tăng tốc độ vào đường cao tốc.','054',0)

insert into DapAn values('148',N'3.Nếu có làn đường tăng tốc thì phải cho xe chạy trên làn đường đó trước khi vào làn đường của đường cao tốc.','054',1)

insert into DapAn values('150',N'1.Phải thực hiện chuyển dần sang làn đường phía bên phải, nếu có làn đường giảm tốc thì phải cho xe chạy trên làn đường đó trước khi rời khỏi đường cao tốc.','055',1)

insert into DapAn values('151',N'2.Phải thực hiện chuyển ngay sang các làn đường phía bên phải, nếu có làn đường giảm tốc thì phải cho xe chạy trên làn đường đó trước khi rời khỏi đường cao tốc.','055',0)

insert into DapAn values('152',N'1.Người đi bộ, xe thô sơ, xe gắn máy và xe ô tô.','056',0)

insert into DapAn values('153',N'2.Xe mô tô và xe máy chuyên dùng có tốc độ thiết kế lớn hơn 70km/h.','056',0)

insert into DapAn values('154',N'3.Người đi bộ, xe thô sơ, xe gắn máy, xe mô tô và xe máy chuyên dùng có tốc độ thiết kế nhỏ hơn 70km/h.','056',1)

insert into DapAn values('155',N'1.Xe cơ giới, xe máy chuyên dùng phải bật đèn, xe thô sơ phải bật đèn hoặc có vật sáng báo hiệu, chỉ được dừng xe, đỗ xe ở nơi quy định.','057',1)

insert into DapAn values('156',N'2.Xe cơ giới phải bật đèn ngay cả khi đường hầm sáng, phải cho xe chạy trên một làn đường và chỉ chuyển làn ở nơi được phép; được quay đầu xe, lùi xe khi cần thiết.','057',0)

insert into DapAn values('157',N'3.Xe máy chuyên dùng phải bật đèn ngay cả khi đường hầm sáng; phải cho xe chạy trên một làn đường và chỉ chuyển làn ở nơi được phép; được quay đầu xe, lùi xe khi cần thiết.','057',0)

insert into DapAn values('158',N'1.Khi tham gia giao thông đường bộ.','058',1)

insert into DapAn values('159',N'2.Chỉ khi đi trên đường cao tốc.','058',0)

insert into DapAn values('160',N'1.Chở người bệnh đi cấp cứu, trẻ em dưới 14 tuổi.','059',1)

insert into DapAn values('161',N'2.Áp giải người có hành vi vi phạm pháp luật.','059',1)

insert into DapAn values('162',N'1.Đi xe dàng hàng ngang.','060',1)

insert into DapAn values('163',N'2.Đi xe vào phần đường dành cho người đi bộ và phương tiện khác, sử dụng ô, điện thoại di động, thiết bị âm thanh( trừ thiết bị trợ thính).','060',1)

insert into DapAn values('164',N'3.Chở người bệnh đi cấp cứu, trẻ em dưới 14 tuổi, áp giải người có hành vi vi phạm pháp luật.','060',0)

insert into DapAn values('165',N'1.Khi tham gia giao thông đường bộ.','061',1)

insert into DapAn values('166',N'2.Chỉ khi tham gia giao thông trên đường quốc lộ, khu vực đô thị.','061',0)

insert into DapAn values('167',N'1.Cơ quan quản lý giao thông vận tải.','062',0)

insert into DapAn values('168',N'2.Uỷ ban nhân dân cấp tỉnh.','062',1)

insert into DapAn values('169',N'3.Cơ quan cảnh sát giao thông đường bộ.','062',0)

insert into DapAn values('170',N'4.Thanh tra giao thông đường bộ.','062',0)

insert into DapAn values('171',N'1.Dừng ngay phương tiện, giữ nguyên hiện trường, cấp cứu người bị nạn và phải có mặt khi cơ quan có thẩm quyền yêu cầu, cung cấp thông tin xác thực về vụ tai nạn cho cơ quan có thẩm quyền.','063',1)

insert into DapAn values('172',N'2.Ở lại nơi xảy ra tai nạn cho đến khi người của cơ quan công an đến, trừ trường hợp người điều khiển phương tiện cũng bị thương phải đưa đi cấp cứu hoặc phải đưa người bị nạn đi cấp cứu hoặc vì lý do đe dọa đến tính mạng nhưng phải đến trình báo ngay với cơ quan công an gần nhất.','063',1)

insert into DapAn values('173',N'3.Rời khỏi hiện trường nơi xảy ra tai nạn giao thông.','063',0)

insert into DapAn values('174',N'1.Bảo vệ hiện trường, giúp đỡ, cứu chữa người bị nạn, bảo vệ tài sản của người bị nạn.','064',1)

insert into DapAn values('175',N'2.Báo tin ngay cho cơ quan công an, y tế hoặc Uỷ ban nhân dân nơi gần nhất, cung cấp thông tin xác thực về vụ tai nạn theo yêu cầu của cơ quan có thẩm quyền.','064',1)

insert into DapAn values('176',N'1.Giấy phép lái xe, đăng kí xe, giấy phép lưu hành xe.','065',0)

insert into DapAn values('177',N'2.Lệnh vận chuyển, đăng kí xe, giấy phép lưu hành xe.','065',0)

insert into DapAn values('178',N'3.Giấy phép lái xe phù hợp với loại xe đó, đăng kí xe, giấy chứng nhận kiểm định kĩ thuật và bảo vệ môi trường, giấy chứng nhận trách nhiệm bảo hiểm trách nhiệm dân sự của chủ xe cơ giới và giấy phép vận chuyển (nếu loại xe đó cần phải có).','065',1)

insert into DapAn values('179',N'1.16 tuổi','066',0)

insert into DapAn values('180',N'2.18 tuổi','066',1)

insert into DapAn values('181',N'1.17 tuổi','066',0)

insert into DapAn values('182',N'1.Nhường đường cho xe đi trên đường nhánh từ bất kỳ hướng nào tới.','067',0)

insert into DapAn values('183',N'2.Nhường đường cho người đi bộ đang đi trên phần đường dành cho người đi bộ sang đường.','067',1)

insert into DapAn values('184',N'3.Nhường đường cho xe đi trên đường ưu tiên, đường chính đi từ bất kì hướng nào tới, nhường đường cho xe ưu tiên, nhường đường cho xe đi từ bên phải đến.','067',1)

insert into DapAn values('185',N'1.Xe mô tô hai bánh có dung tích xilanh từ 50 cm3 trở lên.','068',0)

insert into DapAn values('186',N'2.Nhường đường cho xe đi trên đường nhánh từ bất kỳ hướng nào tới.','068',1)

insert into DapAn values('187',N'3.Xe gắn máy có dung tích xilanh từ 50 cm3 trở xuống.','068',0)

insert into DapAn values('188',N'4.Tất cả các ý trên.','068',0)

insert into DapAn values('189',N'1.05 năm.','069',1)

insert into DapAn values('190',N'2.03 năm.','069',0)

insert into DapAn values('191',N'3.02 năm.','069',0)

insert into DapAn values('192',N'1.Lái xe vào lề đường bên phải và giảm tốc độ để xe phía sau vượt qua.','070',1)

insert into DapAn values('193',N'2.Lái xe vào lề đường bên trái và giảm tốc độ để xe phía sau vượt qua.','070',0)

insert into DapAn values('194',N'3.Lái xe vào lề đường bên phải và tăng tốc độ để xe phía sau vượt qua.','070',0)

insert into DapAn values('195',N'1.Phải đội mũ bảo hiểm có cài quay đúng quy cách, mặc quần áo gọn gàng.','071',1)

insert into DapAn values('196',N'2.Không sử dụng ô, điện thoại di động, thiết bị âm thanh (trừ thiết bị trợ thính).','071',1)

insert into DapAn values('197',N'3.Buông cả hai tay hoặc đi xe bằng 1 bánh.','071',0)

insert into DapAn values('198',N'4.Tất cả các ý nêu trên.','071',0)

insert into DapAn values('199',N'1.Đường bộ nằm trong khu vực nội thành phố, nội thị xã, nội thị trấn, khu công nghiệp có đông người và phương tiện tham gia giao thông.','072',0)

insert into DapAn values('200',N'2.Đường bộ nằm trong khu vực nội thành phố, nội thị xã và những đoạn đường bộ được xác định từ vị trí có hiệu lực của biển báo hiệu “bắt đầu khu đông dân cư” đến vị trí có hiệu lực của biển báo hiệu “hết khu đông dân cư”.','072',1)

insert into DapAn values('201',N'3.Đường bộ có đông người, phương tiện tham gia giao thông và những đoạn đường bộ được xác định từ vị trí có hiệu lực của biển báo hiệu “bắt đầu khu đông dân cư” đến vị trí có hiệu lực của biển báo hiệu “hết khu đông dân cư”.','072',0)

insert into DapAn values('202',N'4.Cả 3 ý trên đều sai.','072',0)

insert into DapAn values('203',N'1.60 km/h.','073',0)

insert into DapAn values('204',N'2.50 km/h.','073',0)

insert into DapAn values('205',N'3.40 km/h.','073',1)

insert into DapAn values('206',N'4.30 km/h.','073',0)

insert into DapAn values('207',N'1.Ô tô chở người trên 30 chỗ ngồi, ô tô tải có trọng tải từ 3500kg trở lên, ô tô sơ mi rơ mooc, ô tô kéo rơ moóc, ô tô kéo xe khác, ô tô chuyên dùng, xe mô tô, xe gắn máy.','074',1)

insert into DapAn values('208',N'2.Ô tô chở người đến 30 chỗ ngồi, ô tô tải có trọng tải dưới 3500 kg.','074',0)

insert into DapAn values('209',N'Xe máy kéo, xe công nông, xe lam, xe lôi máy xe xích lô máy, xe ba gác máy, xe máy chuyên dùng và các loại xe tương tự (loại đang được phép hoạt động)..','074',0)

insert into DapAn values('210',N'1.Ô tô chở người đến 30 chỗ ngồi ( trừ ô tô buýt), ô tô tải có tải trọng dưới 3500 kg.','075',0)

insert into DapAn values('211',N'2.Ô tô chở người trên 30 chỗ ngồi ( trừ ô tô buýt), ô tô tải có trọng tải dưới 3500 kg.','075',0)

insert into DapAn values('212',N'3.Ô tô kéo rơ moóc, ô tô kéo xe khác, xe gắn máy.','075',1)

insert into DapAn values('213',N'4.Ô tô buýt, ô tô sơ mi rơ moóc, ô tô chuyên dùng, xe mô tô.','075',0)

insert into DapAn values('214',N'1.Là sự hiểu biết và chấp hành nghiêm chỉnh pháp luật về giao thông, là ý thức trách nhiệm với cộng đồng khi tham gia giao thông.','076',1)

insert into DapAn values('215',N'2.Là ứng xử văn hóa có tình yêu thương con người trong các tình huống không may xảy ra khi tham gia giao thông.','076',1)

insert into DapAn values('216',N'1.Là bình thường.','077',0)

insert into DapAn values('217',N'2.Là thiếu văn hóa giao thông.','077',1)

insert into DapAn values('218',N'3.Là có văn hóa giao thông.','077',0)

insert into DapAn values('219',N'1.Điều khiển xe đi trên phần đường, làn đường có ít phương tiện tham gia giao thông, đội mũ bảo hiểm ở những nơi có biển báo bắt buộc đội mũ bảo hiểm.','078',0)

insert into DapAn values('220',N'2.Chấp hành quy định về tốc độ, đèn tín hiệu, biển báo hiệu, vạch kẻ đường khi lái xe.','078',1)

insert into DapAn values('221',N'3.Chấp hành hiệu lệnh, chỉ dẫn của người điều khiển giao thông, nhường đường cho người đi bộ, người già, trẻ em, người khuyết tật.','078',1)

insert into DapAn values('222',N'4.Cả 3 ý nêu trên.','078',0)

insert into DapAn values('223',N'1.Điều khiển xe đi bên phải chiều đi của mình.','079',1)

insert into DapAn values('224',N'2.Điều khiển xe đi trên phần đường, làn đường có ít phương tiện tham gia giao thông.','079',0)

insert into DapAn values('225',N'3.Đi đúng phần đường, làn đường quy định; đội mũ bảo hiểm đúng quy cách.','079',1)

insert into DapAn values('226',N'4.Đội mũ bảo hiểm ở nơi có biển báo bắt buộc đội mũ bảo hiểm.','079',0)


insert into DapAn values('227',N'1.Có giấy phép lái xe phù hợp với loại xe được phép điều khiển, xe cơ giới đảm bảo các quy định về chất lượng, an toàn kỹ thuật và bảo vệ môi trường.','080',1)

insert into DapAn values('228',N'2.Có giấy chứng nhận trách nhiệm bảo hiểm dân sự của chủ xe cơ giới còn hiệu lực, nộp phí sử dụng đường bộ theo quy định.','080',1)

insert into DapAn values('229',N'1.Biển 1.','081',0)

insert into DapAn values('230',N'2.Biển 1 và 3','081',0)

insert into DapAn values('231',N'3.Biển 2.','081',1)

insert into DapAn values('232',N'4.Biển 2 và 3.','081',0)

insert into DapAn values('233',N'1.Biển 1.','082',1)

insert into DapAn values('234',N'2.Biển 3','082',0)

insert into DapAn values('235',N'3.Biển 2.','082',0)

insert into DapAn values('236',N'4.Biển 1 và 3.','082',0)

insert into DapAn values('237',N'1.Biển 1.','083',0)

insert into DapAn values('238',N'2.Biển 1 và 3','083',0)

insert into DapAn values('239',N'3.Biển 3.','083',1)

insert into DapAn values('240',N'4. Cả ba biển.','083',0)

insert into DapAn values('241',N'1.Biển 1.','084',0)

insert into DapAn values('242',N'2.Biển 3','084',1)

insert into DapAn values('243',N'3.Biển 2.','084',0)

insert into DapAn values('244',N'4.Biển 1 và 3.','084',1)

insert into DapAn values('245',N'1.Biển 1.','085',1)

insert into DapAn values('246',N'2.Biển 2 và 3.','085',0)

insert into DapAn values('247',N'3.Biển 3.','085',0)

insert into DapAn values('248',N'1.Biển 2.','086',0)

insert into DapAn values('249',N'2.Biển 1.','086',0)

insert into DapAn values('250',N'3.Biển 3.','086',1)

insert into DapAn values('251',N'4.Cả 3 biển.','086',0)

insert into DapAn values('252',N'1.Biển 1 và 3.','087',1)

insert into DapAn values('253',N'2.Biển 1 và 2.','087',0)

insert into DapAn values('254',N'3.Biển 2 và 3.','087',0)

insert into DapAn values('255',N'4.Cả 3 biển trên.','087',0)

insert into DapAn values('256',N'1.Biển 1 và 2.','088',0)

insert into DapAn values('257',N'2.Biển 2 và 3.','088',1)

insert into DapAn values('258',N'3.Biển 1 và 3.','088',0)

insert into DapAn values('259',N'4.Cả 3 biển.','088',0)

insert into DapAn values('260',N'1.Biển 3.','089',1)

insert into DapAn values('261',N'2.Biển 1.','089',0)	 

insert into DapAn values('262',N'3.Biển 2.','089',0)

insert into DapAn values('263',N'1.Biển 1 và 2.','090',0)

insert into DapAn values('264',N'2.Biển 1 và 3.','090',1)

insert into DapAn values('265',N'3.Cả 3 biển.','090',0)

insert into DapAn values('266',N'4.Biển 2 và 3.','090',0)

insert into DapAn values('267',N'1.Biển 1.','091',1)

insert into DapAn values('268',N'2.Biển 2 và 3.','091',0)

insert into DapAn values('269',N'3.Biển 2.','091',0)

insert into DapAn values('270',N'4.Biển 3.','091',0)

insert into DapAn values('271',N'1.Biển 1 và 3.','092',0)

insert into DapAn values('272',N'2.Biển 2.','092',1)

insert into DapAn values('273',N'3.Biển 3.','092',0)

insert into DapAn values('274',N'1.Biển 1.','093',0)

insert into DapAn values('275',N'2.Biển 3.','093',1)

insert into DapAn values('276',N'3.Biển 2.','093',0)

insert into DapAn values('277',N'4.Cả 3 biển.','093',0)

insert into DapAn values('278',N'1.Biển 1.','094',1)

insert into DapAn values('279',N'2.Biển 3.','094',0)

insert into DapAn values('280',N'3.Biển 2.','094',0)

insert into DapAn values('281',N'1.Biển 1.','095',0)

insert into DapAn values('282',N'2.Biển 2.','095',1)

insert into DapAn values('283',N'3.Biển 3.','095',0)

insert into DapAn values('284',N'1.Biển 1.','096',1)

insert into DapAn values('285',N'2.Biển 2.','096',0)

insert into DapAn values('286',N'3.Biển 3.','096',0)

insert into DapAn values('287',N'1.Biển 1.','097',0)

insert into DapAn values('288',N'2.Biển 2.','097',1)

insert into DapAn values('289',N'3.Biển 3.','097',0)

insert into DapAn values('290',N'1.Biển 1.','098',0)

insert into DapAn values('291',N'2.Biển 2.','098',0)

insert into DapAn values('292',N'3.Biển 3.','098',1)

insert into DapAn values('293',N'4.Biển 2 và 3.','098',0)

insert into DapAn values('294',N'1.Biển 1 và 3.','099',0)

insert into DapAn values('295',N'2.Biển 1 và 2.','099',1)

insert into DapAn values('296',N'3.Biển 2 và3.','099',0)

insert into DapAn values('297',N'1.Biển 1.','100',1)

insert into DapAn values('298',N'2.Biển 2.','100',0)

insert into DapAn values('299',N'3.Biển 3.','100',0)

insert into DapAn values('300',N'1.Không biển nào.','101',0)

insert into DapAn values('301',N'2.Biển 1 và2.','101',0)

insert into DapAn values('302',N'3.Biển 2 và3.','101',1)

insert into DapAn values('303',N'4.Cả 3 biển.','101',0)

insert into DapAn values('304',N'1.Biển 1 và 2.','102',0)

insert into DapAn values('305',N'2.Biển 1 và 3.','102',1)

insert into DapAn values('306',N'3.Biển 2 và 3.','102',0)

insert into DapAn values('307',N'1.Biển 1.','103',0)

insert into DapAn values('308',N'2.Biển 2.','103',1)

insert into DapAn values('309',N'3.Biển 3.','103',0)

insert into DapAn values('310',N'1.Cấm các loại xe ở biển phụ đi vào.','104',1)

insert into DapAn values('311',N'2.Cấm các loại xe cơ giới đi vào trừ loại xe ở biển phụ.','104',0)

insert into DapAn values('312',N'1.Biển 1.','105',1)

insert into DapAn values('313',N'2.Biển 2.','105',1)

insert into DapAn values('314',N'3.Không biển nào.','105',0)

insert into DapAn values('315',N'1.Biển 1.','106',1)

insert into DapAn values('316',N'2.Biển 2.','106',0)

insert into DapAn values('317',N'3.Cả 2 biển.','106',0)

insert into DapAn values('318',N'1.Biển 1.','107',0)

insert into DapAn values('319',N'2.Biển 2.','107',1)

insert into DapAn values('320',N'3.Không biển nào.','107',0)

insert into DapAn values('321',N'1.Biển 1.','108',0)

insert into DapAn values('322',N'2.Biển 2.','108',1)

insert into DapAn values('323',N'3.Cả 2 biển.','108',0)

insert into DapAn values('324',N'1.Biển 1 và 3.','109',0)

insert into DapAn values('325',N'2.Biển 2 và 3.','109',0)

insert into DapAn values('326',N'3.Biển 1 và 2.','109',1)

insert into DapAn values('327',N'4.Cả 3 biển.','109',0)

insert into DapAn values('328',N'1.Được phép.','110',0)

insert into DapAn values('329',N'2.Không Được phép.','110',1)

insert into DapAn values('330',N'1.Có.','111',1)

insert into DapAn values('331',N'2.Không.','111',0)

insert into DapAn values('332',N'1.Biển 2 và 3.','112',0)

insert into DapAn values('333',N'2.Biển 1 và 2.','112',0)

insert into DapAn values('334',N'3.Biển 1 và 3.','112',1)

insert into DapAn values('335',N'4.Cả 3 biển.','112',0)

insert into DapAn values('336',N'1.Biển 1.','113',0)

insert into DapAn values('337',N'2.Biển 2.','113',1)

insert into DapAn values('338',N'3.Biển 2 và 3.','113',0)

insert into DapAn values('339',N'1.Biển 1 và 2.','114',1)

insert into DapAn values('340',N'2.Biển 1 và 3.','114',0)

insert into DapAn values('341',N'3.Biển 2 và 3.','114',0)

insert into DapAn values('342',N'1.Biển 1.','115',0)

insert into DapAn values('343',N'2.Biển 2.','115',0)

insert into DapAn values('344',N'3.Biển 3.','115',1)

insert into DapAn values('345',N'4.Biển 1 và 2.','115',0)

insert into DapAn values('346',N'1.Xe tải, xe lam, xe con, mô tô.','116',0)

insert into DapAn values('347',N'2.Xe tải, mô tô, xe lam, xe con.','116',1)

insert into DapAn values('348',N'3.Xe lam, xe tải, xe con, mô tô.','116',0)

insert into DapAn values('349',N'4.Mô tô, xe lam, xe tải, xe con.','116',0)

insert into DapAn values('350',N'1.Xe tải, xe lam, mô tô.','117',0)

insert into DapAn values('351',N'2.Xe lam, xe tải, mô tô.','117',0)

insert into DapAn values('352',N'3.Mô tô, xe lam, xe tải.','117',1)

insert into DapAn values('353',N'4.Xe lam, mô tô, xe tải.','117',0)

insert into DapAn values('354',N'1.Mô tô.','118',0)

insert into DapAn values('355',N'2.Xe con.','118',1)

insert into DapAn values('356',N'1.Xe lam, xe cứu thương, xe con.','119',1)

insert into DapAn values('357',N'2.Xe cứu thương, xe con, xe lam.','119',0)

insert into DapAn values('358',N'3.Xe con, xe lam, xe cứu thương.','119',0)

insert into DapAn values('359',N'1.Mô tô.','120',0)

insert into DapAn values('360',N'2.Xe cứu thương.','120',1)

insert into DapAn values('361',N'1.Xe con và xe khách','121',1)

insert into DapAn values('362',N'2.Mô tô.','121',0)

insert into DapAn values('363',N'1.Xe khách, mô tô.','122',0)

insert into DapAn values('364',N'2.Xe tải, mô tô.','122',0)

insert into DapAn values('365',N'3.Xe con, xe tải.','122',1)

insert into DapAn values('366',N'1.Xe khách, xe tải, mô tô.','123',1)

insert into DapAn values('367',N'2.Xe tải, xe con, mô tô.','123',0)

insert into DapAn values('368',N'3.Xe khách, xe con, mô tô.','123',0)

insert into DapAn values('369',N'1.Xe khách, xe tải, mô tô, xe con.','124',0)

insert into DapAn values('370',N'2.Xe con, xe khách, xe tải, mô tô.','124',0)

insert into DapAn values('371',N'3.Mô tô, xe tải, xe khách, xe con.','124',1)

insert into DapAn values('372',N'4.Mô tô, xe tải, xe con, xe khách.','124',0)

insert into DapAn values('373',N'1.Xe tải.','125',1)

insert into DapAn values('374',N'2.Xe con và mô tô.','125',0)

insert into DapAn values('375',N'3.Cả ba xe.','125',0)

insert into DapAn values('376',N'4.Xe con và xe tải.','125',0)

insert into DapAn values('377',N'1.Xe tải.','126',0)

insert into DapAn values('378',N'2.Xe con.','126',1)

insert into DapAn values('379',N'3.Xe lam.','126',0)

insert into DapAn values('380',N'1.Cả ba hướng.','127',1)

insert into DapAn values('381',N'2.Hướng 1 và 3.','127',0)

insert into DapAn values('382',N'3.Chỉ hướng 1.','127',0)

insert into DapAn values('383',N'1.Cả hai xe.','128',1)

insert into DapAn values('384',N'2.Không xe nào vi phạm.','128',0)

insert into DapAn values('385',N'3.Chỉ xe mô tô vi phạm.','128',0)

insert into DapAn values('386',N'4.Chỉ xe tải vi phạm.','128',0)

insert into DapAn values('387',N'1.Mô tô.','129',0)

insert into DapAn values('388',N'2.Xe tải.','129',0)

insert into DapAn values('389',N'3.Cả ba xe.','129',1)

insert into DapAn values('390',N'4.Mô tô và xe tải.','129',0)

insert into DapAn values('391',N'1.Đúng.','130',0)

insert into DapAn values('392',N'2.Không đúng.','130',1)

insert into DapAn values('393',N'1.Xe lam.','131',0)

insert into DapAn values('394',N'2.Xe xích lô.','131',1)

insert into DapAn values('395',N'1.Xe lam, mô tô, xe con, xe đạp.','132',0)

insert into DapAn values('396',N'2.Xe con, xe đạp, mô tô, xe lam.','132',0)

insert into DapAn values('397',N'3.Xe lam, xe con, mô tô + xe đạp','132',1)

insert into DapAn values('398',N'4.Mô tô + xe đạp, xe lam, xe con.','132',0)

insert into DapAn values('399',N'1.Mô tô.','133',1)

insert into DapAn values('400',N'2.Xe con.','133',0)

insert into DapAn values('401',N'1.Xe khách.','134',0)

insert into DapAn values('402',N'2.Mô tô.','134',0)

insert into DapAn values('403',N'3.Xe con.','134',1)

insert into DapAn values('404',N'4.Xe con và mô tô.','134',0)

insert into DapAn values('405',N'1.Các xe ở phía tay phải và tay trái của người điều khiển được phép đi thẳng.','135',0)

insert into DapAn values('406',N'2.Cho phép các xe ở mọi hướng được rẽ phải.','135',0)

insert into DapAn values('407',N'3.Tất cả các xe phải dừng lại trước ngã tư, trừ những xe đã ở trong ngã tư được phép tiếp tục đi.','135',1)

insert into DapAn values('408',N'1.Mô tô, xe con.','136',0)

insert into DapAn values('409',N'2.Xe con, xe tải.','136',0)

insert into DapAn values('410',N'3.Mô tô, xe tải.','136',1)

insert into DapAn values('411',N'4.Cả ba xe.','136',0)

insert into DapAn values('412',N'1.Xe khách, mô tô.','137',0)

insert into DapAn values('413',N'2.Tất cả các loại xe trên.','137',1)

insert into DapAn values('414',N'3.Không xe nào chấp hành đúng quy tắc giao thông.','137',0)

insert into DapAn values('415',N'1.Cả ba hướng.','138',0)

insert into DapAn values('416',N'2.Hướng 1 và 2.','138',0)

insert into DapAn values('417',N'3.Hướng 1 và 3.','138',1)

insert into DapAn values('418',N'4.Hướng 2 và 3.','138',0)

insert into DapAn values('419',N'1.Xe công an, xe quân sự, xe con + mô tô.','139',0)

insert into DapAn values('420',N'2.Xe quân sự, xe công an, xe con + mô tô.','139',1)

insert into DapAn values('421',N'3.Xe mô tô + xe con, xe quân sự, xe công an.','139',0)

insert into DapAn values('422',N'1.Xe con (E), mô tô (C).','140',1)

insert into DapAn values('423',N'2.Xe tải (A), mô tô (D).','140',0)

insert into DapAn values('424',N'3.Xe khách (B), mô tô (C).','140',0)

insert into DapAn values('425',N'4.Xe khách (B), mô tô (C).','140',0)

insert into DapAn values('426',N'1.Xe con (B), mô tô (C).','141',0)

insert into DapAn values('427',N'2.Xe con (A), mô tô (C).','141',0)

insert into DapAn values('428',N'3.Xe con (E), mô tô (D).','141',1)

insert into DapAn values('429',N'4.Tất cả các loại xe trên.','141',0)

insert into DapAn values('430',N'1.Xe khách, mô tô.','142',0)

insert into DapAn values('431',N'2.Xe tải, mô tô.','142',0)

insert into DapAn values('432',N'3.Xe con, xe tải.','142',1)

insert into DapAn values('433',N'1.Cho phép.','143',0)

insert into DapAn values('434',N'2.Không được vượt.','143',1)

insert into DapAn values('435',N'1.Xe mô tô.','144',1)

insert into DapAn values('436',N'2.Xe ô tô con.','144',1)

insert into DapAn values('437',N'3.Không xe nào vi phạm.','144',0)

insert into DapAn values('438',N'1.Xe con.','145',0)

insert into DapAn values('439',N'2.Xe tải.','145',1)

insert into DapAn values('440',N'3.Xe con, xe tải.','145',0)

insert into DapAn values('441',N'1.Xe tải, xe con.','146',0)

insert into DapAn values('442',N'2.Xe khách, xe con.','146',0)

insert into DapAn values('443',N'3.Xe khách, xe tải.','146',1)

insert into DapAn values('444',N'1.Xe con, xe tải, xe khách.','147',0)

insert into DapAn values('445',N'2.Xe tải, xe khách, xe mô tô.','147',1)

insert into DapAn values('446',N'3.Xe khách, xe mô tô, xe con.','147',0)

insert into DapAn values('447',N'4.Cả bốn xe.','147',0)

insert into DapAn values('448',N'1.Xe tải, mô tô.','148',0)

insert into DapAn values('449',N'2.Xe khách, mô tô.','148',1)

insert into DapAn values('450',N'3.Xe tải, xe con.','148',0)

insert into DapAn values('451',N'1.Xe của bạn, mô tô, xe con.','149',0)

insert into DapAn values('452',N'2.Xe con, xe của bạn, mô tô.','149',0)

insert into DapAn values('453',N'3.Mô tô, xe con, xe của bạn.','149',1)

insert into DapAn values('454',N'1.Xe của bạn, mô tô, xe con.','150',0)

insert into DapAn values('455',N'2.Xe con, xe của bạn, mô tô.','150',1)

insert into DapAn values('456',N'3.Mô tô, xe con, xe của bạn.','150',0)

insert into TaiKhoan values('admin', 'admin', 1)
insert into TaiKhoan values('htthinh', '123', 0)
insert into TaiKhoan values('ducbac', '123', 0)

insert into ThiSinh values('TS001', N'Huỳnh Tấn Thịnh', '1999-09-27', 'M', N'Vạn Giã', 'htthinh')
insert into ThiSinh values('TS002', N'Đinh Đức Bắc', '19980102', 'M', N'Quảng Trị', 'ducbac')

insert into KetQua(MaThiSinh, ThoiGian, LanThi, KetQua) values((select MaThiSinh from ThiSinh where Username='htthinh'), CURRENT_TIMESTAMP, 1, '20/20')
insert into KetQua(MaThiSinh, ThoiGian, LanThi, KetQua) values((select MaThiSinh from ThiSinh where Username='htthinh'), CURRENT_TIMESTAMP, 2, '17/20')
insert into KetQua(MaThiSinh, ThoiGian, LanThi, KetQua) values((select MaThiSinh from ThiSinh where Username='ducbac'), CURRENT_TIMESTAMP, 1, '20/20')

Select T.MaThiSinh AS N'Mã Thí Sinh', HoTenThiSinh AS N'Họ Tên', LanThi AS N'Lần Thi', ThoiGian AS N'Thời Gian', KetQua AS N'Kết Quả'
from KetQua K inner join ThiSinh T on K.MaThiSinh = T.MaThiSinh
order by T.MaThiSinh
