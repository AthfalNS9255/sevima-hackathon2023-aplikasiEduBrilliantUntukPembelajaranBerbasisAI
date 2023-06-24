create table [User] (
	ID int not null primary key Identity,
	NamaLengkap varchar(100) not null,
	Username varchar(100) not null,
	Password varchar(100) not null,
	NoTelp varchar(15) not null,
	Email varchar(100) null,
	Role varchar(15) not null,
)

create table Kategori (
	ID int Not null primary key identity,
	Nama varchar(50) not null
)

create Table Kelas (
	ID int not null primary key identity,
	KategoriID int not null,
	Nama varchar(100) not null,
	Harga int not null,
	constraint FK_Kelas_KategoriID foreign key (KategoriID) references Kategori(ID)
)

create Table Transaksi (
	ID int not null primary key identity,
	UserID int not null,
	KelasID int not null,
	DateActivated datetime null,
	Token varchar(6) not null,
	IsActive int not null,
	constraint FK_Transaksi_UserID foreign key (UserID) references [User](ID),
	constraint FK_Transaksi_KelasID foreign key (KelasID) references Kelas(ID)
)

create table Soal (
	ID int Not null primary key identity,
	Nama varchar(50) not null,
	KelasID int not null,
	Waktu int not null,
	Deadline datetime not null,
	MaxScore int not null,
	constraint FK_Soal_KelasID foreign key (KelasID) references Kelas(ID)
)

create table Score (
	ID int not null primary key identity,
	UserID int not null,
	SoalID int not null,
	Score decimal(18,2) not null,
	constraint FK_Score_UserID foreign key (UserID) references [User](ID),
	constraint FK_Score_SoalID foreign key (SoalID) references Soal(ID)
)
