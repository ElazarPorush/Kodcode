--יצירת טבלת קורסים
create table Courses(CourseId int primary key identity,
CourseName varchar(50),
DateOfStart Date,
DaysOnWeek int,
HoursOnDay int,
CoursePrice float
);

--יצירת טבלת נושאים
create table Subjects(SubjectId int primary key identity,
SubjectName varchar(50),
NumberOfHours int,
TeacherName varchar(50),
HourPrice float,
IdCourse int foreign key references Courses(CourseId)
);

--יצירת טבלת סטודנטים
create table Students(StudentId int primary key identity,
StudentName varchar(50)
);

--יצירת טבלת תשלומים(טבלה מקשרת
create table Payments(PaymentId int primary key identity,
IdStudent int foreign key references Students(StudentId),
IdCourse int foreign key references Courses(CourseId),
IsPay bit
);

--יצירת טבלת הרשמה לנושאים
create table StudentSubjects (Code int primary key identity,
IdStudent int foreign key references Students(StudentId),
IdCourse int foreign key references Courses(CourseId),
IdSubject int foreign key references Subjects(SubjectId)
);


--הדפסת הטבלאות
select * from Courses
select * from Subjects
select * from Students
select * from Payments
select * from StudentSubjects



--יצירת שאילתות
declare @CourseNamee varchar(50) = 'Programing';

declare @CourseCode int;
select @CourseCode = (select CourseId from Courses where CourseName = @CourseNamee) 
delete from StudentSubjects where IdCourse = @CourseCode
delete from Payments where IdCourse = @CourseCode
delete from Subjects where IdCourse = @CourseCode
delete from Courses where CourseId = @CourseCode


--add course (Manejer)

--Declare variable
declare @CourseName varchar(50) = 'Programing', @DateOfStart Date = '2024/07/23', @DaysOnWeek int= 3, @HoursOnDay int = 6, @CoursePrice float = 25000;
--search course
if not exists(select CourseName from Courses where CourseName = @CourseName)
	begin
		--add course
		insert into Courses values (@CourseName, @DateOfStart, @DaysOnWeek, @HoursOnDay, @CoursePrice)
	end


--add Subject
declare @SubjectName varchar(50)='sql', @NumberOfHours int= 90, @TeacherName varchar(50)='Tomer', @HourPrice float=75.5, @CourseName1 varchar(50)='Programing';

declare @CoursCode int;
select @CoursCode = (select CourseId from Courses where CourseName = @CourseName1);
insert into Subjects values (@SubjectName, @NumberOfHours, @TeacherName, @HourPrice, @CoursCode)


--add Student
declare @StudentName varchar(50) = 'Elazar';
if not exists(select StudentName from Students where StudentName = @StudentName)
	begin
		insert into Students values (@StudentName)
	end


--add Payment
declare @NameStudent varchar(50), @NameCourse varchar(50), @IsPay bit;

declare @CodeStudent int, @CodeCourse int;
select @CodeStudent = (select StudentId from Students where StudentName = @NameStudent);
select @CodeCourse = (select CourseId from Courses where CourseName = @NameCourse);
if not exists (select * from Payments where IdStudent = @CodeStudent
and IdCourse = @CodeCourse)
	begin
		insert into Payments values (@CodeStudent, @CodeCourse, @IsPay)
	end



declare @CourseName2 varchar(50) = 'Programing';

declare @CourseCode2 int;
select @CourseCode2 = (select CourseId from Courses where CourseName = @CourseName2);
select * from Subjects where IdCourse = @CourseCode2;


declare @SubjectName1 varchar(50) = 'SQL';

declare @SubjectCode int;
select @SubjectCode = (select SubjectId from Subjects where SubjectName = @SubjectName1);
delete from StudentSubjects where IdSubject = @SubjectCode;
delete from Subjects where SubjectId = @SubjectCode;
