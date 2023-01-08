UPDATE Registration SET password = 1234 , re_password = 1234 WHERE pancard = 'HHJG' AND adhaar_no = 'JGJM' AND username = 'gf';

--add_account create query
CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no int, pan nvarchar(10), aadhaar nvarchar(12), gst_no nvarchar(15), acc_add_date date, primary key(acc_name));

--delete table
DROP DATABASE ADD_ACCOUNT


--create table if not exists
USE [dball]
GO
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = N'ADD_ACCOUNT')
BEGIN
SELECT ID FROM ADD_ACCOUNT WHERE ID = 1
PRINT 'Table exists.'
END
ELSE
BEGIN
CREATE TABLE ADD_ACCOUNT(id int, acc_name nvarchar(50), type_of_customer nvarchar(10), opening_balance float, address nvarchar(500), city nvarchar(20), pincode int, phone_no int, pan nvarchar(10), aadhaar nvarchar(12), gst_no nvarchar(15), acc_add_date date, primary key(acc_name));
PRINT 'Table does not exist.'
END


-- SELECT DATA START WITH SELECTED LETTER
select acc_name from ADD_ACCOUNT WHERE acc_name LIKE '%'

select * from ADD_ACCOUNT WHERE acc_name = 'HGDJSH'