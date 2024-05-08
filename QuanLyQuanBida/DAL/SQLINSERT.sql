USE QUANLYQUANBIDA
 -- 1
INSERT INTO ACCESS_TBL (IDACCESS, NAMEACCESS)
VALUES 
	(1, 'Admin'),
	(2,'Staff');

-- 2
INSERT INTO STAFFS(IDSTAFF,NAMESTAFF,PHONENUM,POSITION, ACCOUNT) 
VALUES
	('NV0001','KHANH','0942824505','ADMIN', 'admin1')

-- 3
INSERT INTO USERS_TBL (ACCOUNT, PASS, IDACCESS)
VALUES 
	('admin1', 'p123', 1)

-- 4
INSERT INTO BILLARDTABLE (IDTABLE, CLASSIFY, PRICE)
VALUES 
	('1', 'Pool', 49000),
	('2', 'Pool', 49000),
	('3', 'Pool', 49000),
	('4', 'Pool', 49000),
	('5', 'Pool', 49000),
	('6', 'Libre', 39000),
	('7', 'Libre', 39000),
	('8', 'Libre', 39000),
	('9', 'Libre', 39000),
	('10', 'Libre', 39000),
	('11', 'Carom', 59000),
	('12', 'Carom', 59000),
	('13', 'Carom', 59000),
	('14', 'Carom', 59000),
	('15', 'Carom', 59000);

-- 5
INSERT INTO SETTABLE (IDTABLE)
VALUES 
	('1'),
	('2'),
	('3'),
	('4'),
	('5'),
	('6'),
	('7'),
	('8'),
	('9'),
	('10'),
	('11'),
	('12'),
	('13'),
	('14'),
	('15');