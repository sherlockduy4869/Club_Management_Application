CREATE DATABASE OOP_PROJECT
GO
USE OOP_PROJECT
GO

/*Table Area*/
--Table Account
CREATE TABLE Account
(
	Id CHAR(10) ,
	UserName VARCHAR(50),
	Pass VARCHAR(50),
	Role VARCHAR(50)
)
GO

--Table Info_Member
CREATE TABLE Info_Member
(
	STT INT IDENTITY,
	Id CHAR(10),
	Name VARCHAR(100),
	Class VARCHAR(20),
	Phone VARCHAR(20),
	Role VARCHAR(20) DEFAULT 'Member', 
	Team VARCHAR(50) 
)
GO
--Table Info_Leader
CREATE TABLE Info_Leader
(
	STT INT IDENTITY,
	Id CHAR(10) ,
	Name VARCHAR(100),
	Class VARCHAR(20),
	Phone VARCHAR(20),
	Role VARCHAR(20) DEFAULT 'Leader',
	Team VARCHAR(50) 
)
GO

--Table Info_Mentor
CREATE TABLE Info_Mentor
(
	STT INT IDENTITY,
	Id CHAR(10) ,
	Name VARCHAR(100),
	Class VARCHAR(20),
	Phone VARCHAR(20),
	Role VARCHAR(20) DEFAULT 'Mentor'
)
GO
--Table Info_Activity
CREATE TABLE Info_Activity
(
	STT INT IDENTITY,
	Id CHAR(10),
	Name VARCHAR(100),
	DateStart VARCHAR(50),
	DateEnd VARCHAR(50),
)
GO
--Table Info Finance_Detail
CREATE TABLE Finance_Detail
(	
	IdActivity CHAR(10) ,
	ItemName VARCHAR(50),
	Price INT,
	Quantity INT,
)
GO
--Table Info_Task
CREATE TABLE Info_Task
(
	STT INT IDENTITY,
	Id_Member CHAR(10),
	Name VARCHAR(50),
	Task_Id VARCHAR(50),
	Task_Name VARCHAR(100),
	Deadline VARCHAR(50),
	Status VARCHAR(50) DEFAULT 'Working',
	Note VARCHAR(200) DEFAULT 'None',
	Priority VARCHAR(20)
)
GO
/*Proc Area*/
-- Proc for Login
CREATE PROC Login
@userName VARCHAR(50), @passWord VARCHAR(50)
AS
BEGIN
	SELECT * FROM Account WHERE UserName = @userName AND Pass = @passWord
END
GO

-- Proc for loading information of member
CREATE PROC LoadInfoListMember
AS
BEGIN
	SELECT Id, Name, Class, Phone, Team FROM Info_Member 
END
GO

-- Proc for loading information of leader
CREATE PROC LoadInfoListLeader
AS
BEGIN
	SELECT Id, Name, Class, Phone, Team  FROM Info_Leader 
END
GO

-- Proc for loading information of mentor
CREATE PROC LoadInfoListMentor
AS
BEGIN
	SELECT Id, Name, Class, Phone FROM Info_Mentor
END
GO

-- Proc for loading information of activity
CREATE PROC LoadInfoActivity
AS
BEGIN
	SELECT * FROM Info_Activity
END
GO

--Proc for adjusting information of member/leader/mentor
CREATE PROC Adjust_Info
@userName VARCHAR(50), @name VARCHAR(50), @clas VARCHAR(50), @phone VARCHAR(50), @role VARCHAR(50)
AS
BEGIN
	IF(@role = 'Member')
	BEGIN
	UPDATE Info_Member
	SET Name = @name, Class = @clas, Phone = @phone
	WHERE Id = @userName
	END

	IF(@role = 'Leader')
	BEGIN
	UPDATE Info_Leader
	SET Name = @name, Class = @clas, Phone = @phone
	WHERE Id = @userName
	END

	IF(@role = 'Mentor')
	BEGIN
	UPDATE Info_Mentor
	SET Name = @name, Class = @clas, Phone = @phone
	WHERE Id = @userName
	END
END
GO

--Proc for adjusting password
CREATE PROC Adjust_Pass
@userName VARCHAR(50), @newPass VARCHAR(50)
AS
BEGIN
	UPDATE Account
	SET Pass = @newPass
	WHERE UserName = @userName
END
GO

--Proc for inserting finance detail
CREATE PROC USP_InsertFinanceDetail
@idActivity VARCHAR(50), @itemName VARCHAR(50), @price INT, @quantity INT
AS
BEGIN
	DECLARE @isExitItem INT
	SELECT @isExitItem = COUNT(*) FROM dbo.Finance_Detail WHERE ItemName = @itemName AND Price = @price AND IdActivity = @idActivity
	
	DECLARE @count INT
	SELECT @count = Quantity FROM dbo.Finance_Detail WHERE ItemName = @itemName AND Price = @price AND IdActivity = @idActivity

	IF(@isExitItem != 0)
	BEGIN
		DECLARE @newcount INT = @count + @quantity

		IF(@newcount > 0)
		BEGIN
			UPDATE Finance_Detail
			SET Quantity = @count + @quantity
			WHERE ItemName = @itemName AND Price = @price AND IdActivity = @idActivity
		END

		ELSE
		BEGIN
			DELETE Finance_Detail WHERE ItemName = @itemName AND Price = @price AND IdActivity = @idActivity
		END
	END

	ELSE IF(@quantity >0)
	BEGIN
		INSERT INTO Finance_Detail(IdActivity, ItemName, Price, Quantity) VALUES(@idActivity, @itemName, @price, @quantity)
	END
END
GO

/*Trigger Area*/
--Trigger for inserting MemberID
CREATE TRIGGER InsertMemberID
ON Info_Member
FOR INSERT
AS
BEGIN
	DECLARE @stt INT
	DECLARE @id VARCHAR(50)

	SELECT @stt = STT FROM inserted

	SET @id = 'MB'+ CONVERT(VARCHAR,@stt)
	UPDATE Info_Member
	SET Id = @id
	WHERE STT = @stt
END
GO

--Trigger for inserting LeaderID
CREATE TRIGGER InsertLeaderID
ON Info_Leader
FOR INSERT
AS
BEGIN
	DECLARE @stt INT
	DECLARE @id VARCHAR(50)

	SELECT @stt = STT FROM inserted

	SET @id = 'LD'+ CONVERT(VARCHAR,@stt)
	UPDATE Info_Leader
	SET Id = @id
	WHERE STT = @stt
END
GO

--Trigger for inserting MentorID
CREATE TRIGGER InsertMentorID
ON Info_Mentor
FOR INSERT
AS
BEGIN
	DECLARE @stt INT
	DECLARE @id VARCHAR(50)

	SELECT @stt = STT FROM inserted

	SET @id = 'MT'+ CONVERT(VARCHAR,@stt)
	UPDATE Info_Mentor
	SET Id = @id
	WHERE STT = @stt
END
GO

--Trigger for inserting MentorID
CREATE TRIGGER InsertTaskID
ON Info_Task
FOR INSERT
AS
BEGIN
	DECLARE @stt INT
	DECLARE @id VARCHAR(50)

	SELECT @stt = STT FROM inserted

	SET @id = 'T'+ CONVERT(VARCHAR,@stt)
	UPDATE Info_Task
	SET Task_Id = @id
	WHERE STT = @stt
END
GO

--Trigger for inserting ActivityID
CREATE TRIGGER InsertAcitivitID
ON Info_Activity
FOR INSERT
AS
BEGIN
	DECLARE @stt INT
	DECLARE @id VARCHAR(50)

	SELECT @stt = STT FROM inserted

	SET @id = 'AT'+ CONVERT(VARCHAR,@stt)
	UPDATE Info_Activity
	SET Id = @id
	WHERE STT = @stt
END
GO

-- Trigger for creating new account when inserting new member
CREATE TRIGGER Insert_Account
ON Info_Member
FOR UPDATE, INSERT
AS
BEGIN
	DECLARE @id VARCHAR(50)
	DECLARE @role VARCHAR(50)

	SELECT @id = Id From inserted
	SELECT @role = Role From inserted

	IF(@id is not Null)
	BEGIN
		INSERT INTO Account(Id, UserName, Pass, Role) VALUES (@id,@id,'2251022057731868917119086224872421513662',@role)
	END
END
GO

-- Trigger for creating new account when inserting new leader
CREATE TRIGGER Insert_Account_Leader
ON Info_Leader
FOR UPDATE, INSERT
AS
BEGIN
	DECLARE @id VARCHAR(50)
	DECLARE @role VARCHAR(50)

	SELECT @id = Id From inserted
	SELECT @role = Role From inserted

	IF(@id is not Null)
	BEGIN
		INSERT INTO Account(Id, UserName, Pass, Role) VALUES (@id,@id,'2251022057731868917119086224872421513662',@role)
	END
END
GO

-- Trigger for creating new account when inserting new mentor
CREATE TRIGGER Insert_Account_Mentor
ON Info_Mentor
FOR UPDATE, INSERT
AS
BEGIN
	DECLARE @id VARCHAR(50)
	DECLARE @role VARCHAR(50)

	SELECT @id = Id From inserted
	SELECT @role = Role From inserted

	IF(@id is not Null)
	BEGIN
		INSERT INTO Account(Id, UserName, Pass, Role) VALUES (@id,@id,'2251022057731868917119086224872421513662',@role)
	END
END
GO

-- Trigger for deleting account when deleting member
CREATE TRIGGER Delete_Account
ON Info_Member
FOR Delete
AS
BEGIN
	DECLARE @id VARCHAR(50)
	DECLARE @role VARCHAR(50)

	SELECT @id = Id From deleted
	SELECT @role = Role From deleted

	DELETE FROM Account WHERE id = @id AND Role = @role

END
GO

-- Trigger for deleting account when deleting leader
CREATE TRIGGER Delete_Account_Leader
ON Info_Leader
FOR Delete
AS
BEGIN
	DECLARE @id VARCHAR(50)
	DECLARE @role VARCHAR(50)

	SELECT @id = Id From deleted
	SELECT @role = Role From deleted

	DELETE FROM Account WHERE id = @id AND Role = @role

END
GO

-- Trigger for deleting account when deleting mentor
CREATE TRIGGER Delete_Account_Mentor
ON Info_Mentor
FOR Delete
AS
BEGIN
	DECLARE @id VARCHAR(50)
	DECLARE @role VARCHAR(50)

	SELECT @id = Id From deleted
	SELECT @role = Role From deleted

	DELETE FROM Account WHERE id = @id AND Role = @role

END
GO
--Trigger for Insert member name in Info_Task
CREATE TRIGGER InsertMemberName
ON Info_Task
FOR INSERT
AS
BEGIN
	DECLARE @Name VARCHAR(40)
	DECLARE @id VARCHAR(20)

	SELECT @id = Id_Member FROM inserted 
	SELECT @Name = Name FROM Info_Member WHERE Id = @id

	UPDATE Info_Task
	SET Name = @Name
	WHERE Id_Member = @id
END
GO
--Insert first Leader
INSERT INTO Info_Leader (Name, Class, Phone,Team) VALUES('Admin','adminClass', '09676546546','Media')
GO
