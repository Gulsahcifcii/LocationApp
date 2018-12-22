create table campus
(
  CampusID    int auto_increment
    primary key,
  Name        varchar(50) charset utf8  null,
  Description varchar(100) charset utf8 null,
  Other       varchar(150) charset utf8 null
);

create table mainunit
(
  MainUnitID int auto_increment
    primary key,
  Name       varchar(50) charset utf8 null
);

create table roomtype
(
  RoomTypeID  int auto_increment
    primary key,
  Name        varchar(50) charset utf8 null,
  Description varchar(50) charset utf8 null
);

create table site
(
  SiteID      int auto_increment
    primary key,
  Name        varchar(50) charset utf8 null,
  Description varchar(50) charset utf8 null,
  Gps         varchar(50) charset utf8 null
);

create table build
(
  BuildID    int auto_increment
    primary key,
  SiteID     int                       null,
  Name       varchar(50) charset utf8  null,
  Adress     varchar(150) charset utf8 null,
  Gps        varchar(50) charset utf8  null,
  Properties varchar(150) charset utf8 null,
  CampusID   int                       null,
  constraint build_campus_CampusID_fk
    foreign key (CampusID) references campus (campusid),
  constraint build_site_SiteID_fk
    foreign key (SiteID) references site (siteid)
);

create table block
(
  BlockID int auto_increment
    primary key,
  BuildID int                      null,
  Name    varchar(50) charset utf8 null,
  Gps     varchar(50) charset utf8 null,
  constraint block_build_BuildID_fk
    foreign key (BuildID) references build (buildid)
);

create table campussite
(
  CampusSiteID int auto_increment
    primary key,
  SiteID       int                      null,
  CampusID     int                      null,
  Other        varchar(50) charset utf8 null,
  constraint campussite_campus_CampusID_fk
    foreign key (CampusID) references campus (campusid),
  constraint campussite_site_SiteID_fk
    foreign key (SiteID) references site (siteid)
);

create table floor
(
  FloorID int auto_increment
    primary key,
  BlockID int                      null,
  Name    varchar(50) charset utf8 null,
  Other   varchar(50) charset utf8 null,
  Map     varchar(50) charset utf8 null,
  BuildID int                      null,
  constraint floor_block_BlockID_fk
    foreign key (BlockID) references block (blockid),
  constraint floor_build_BuildID_fk
    foreign key (BuildID) references build (buildid)
);

create table room
(
  RoomID     int auto_increment
    primary key,
  FloorID    int                      null,
  Name       varchar(50) charset utf8 null,
  RoomTypeID int                      null,
  Map        varchar(50) charset utf8 null,
  constraint room_floor_FloorID_fk
    foreign key (FloorID) references floor (floorid),
  constraint room_roomtype_RoomTypeID_fk
    foreign key (RoomTypeID) references roomtype (roomtypeid)
);

create table subunit
(
  SubUnitID  int auto_increment
    primary key,
  Name       varchar(50) charset utf8 null,
  MainUnitID int                      null,
  constraint Fk_MainUnitID
    foreign key (MainUnitID) references mainunit (mainunitid)
);

create table department
(
  DepartmentID int auto_increment
    primary key,
  Name         varchar(50) charset utf8  null,
  Description  varchar(50) charset utf8  null,
  Other        varchar(100) charset utf8 null,
  SubUnitID    int                       null,
  constraint FK_SubUnitID
    foreign key (SubUnitID) references subunit (subunitid)
);

create table departmentroom
(
  DepartmentRoomID int auto_increment
    primary key,
  RoomID           int                      null,
  DepartmentID     int                      null,
  Other            varchar(50) charset utf8 null,
  constraint departmentroom_department_DepartmentID_fk
    foreign key (DepartmentID) references department (departmentid),
  constraint departmentroom_room_RoomID_fk
    foreign key (RoomID) references room (roomid)
);

create table usercontacttype
(
  UserContactTypeID int auto_increment
    primary key,
  TypeName          varchar(50) charset utf8 null,
  Description       varchar(50) charset utf8 null
);

create table userrole
(
  UserRoleID          int auto_increment
    primary key,
  UserRoleName        varchar(50) charset utf8 null,
  UserRoleDescription varchar(50) charset utf8 null,
  Active              tinyint(1)               null
);

create table usertitle
(
  UserTitleID int auto_increment
    primary key,
  TitleName   varchar(50) charset utf8 null
);

create table user
(
  UserID      int auto_increment
    primary key,
  Name        varchar(50) charset utf8 null,
  SurName     varchar(50) charset utf8 null,
  Gender      bit                      null,
  NationID    text                     null,
  UserTitleID int                      null,
  constraint user_usertitle_UserTitleID_fk
    foreign key (UserTitleID) references usertitle (usertitleid)
);

create table usercontact
(
  UserContactID     int auto_increment
    primary key,
  Contact           varchar(50) charset utf8 null,
  UserID            int                      null,
  UserContactTypeID int                      null,
  constraint usercontact_user_UserID_fk
    foreign key (UserID) references user (userid),
  constraint usercontact_usercontacttype_UserContactTypeID_fk
    foreign key (UserContactTypeID) references usercontacttype (usercontacttypeid)
);

create table userdepartment
(
  UserDepartmentID int auto_increment
    primary key,
  UserID           int null,
  DepartmentID     int null,
  constraint FK_DepartmentID
    foreign key (DepartmentID) references department (departmentid),
  constraint userdepartment_user_UserID_fk
    foreign key (UserID) references user (userid)
);

create table userlogin
(
  UserLoginID  int auto_increment
    primary key,
  Password     varchar(50) charset utf8 null,
  CreationDate date                     null,
  IpAdress     varchar(20) charset utf8 null,
  UserID       int                      null,
  constraint userlogin_user_UserID_fk
    foreign key (UserID) references user (userid)
);

create table userpassword
(
  UserPasswordID int auto_increment
    primary key,
  Password       varchar(20) charset utf8 null,
  UserID         int                      null,
  constraint userpassword_user_UserID_fk
    foreign key (UserID) references user (userid)
);

create table useruserrole
(
  UserUserRoleID int auto_increment
    primary key,
  UserID         int null,
  UserRoleID     int null,
  constraint FK_UserRoleID
    foreign key (UserRoleID) references userrole (userroleid),
  constraint useruserrole_user_UserID_fk
    foreign key (UserID) references user (userid)
);


