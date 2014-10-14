USE [D:\DOKUMENTY\_GIT\_CSHARP_2013\TESTY\SCHOOL\SCHOOLDB.MDF]
GO

select c.courseid, c.coursename,c.Location, c.TeacherId
from student s left outer join studentcourse sc on sc.studentid = s.studentid left outer join course c on c.courseid = sc.courseid
where s.studentid = 1


/*
DECLARE	@StudentId int
Set @StudentId=1
EXEC	[dbo].[GetCoursesByStudentId] @StudentId
*/
