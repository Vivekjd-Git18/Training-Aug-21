CREATE TABLE jobs(
	JobId SMALLINT,
	JobTile VARCHAR(20) DEFAULT ' ',
	MinSalary SMALLMONEY DEFAULT '8000',
	MaxSalary SMALLMONEY 
);
INSERT INTO jobs(JobId,JobTile,MaxSalary) VALUES(1,'sde',21000);

SELECT * FROM jobs;