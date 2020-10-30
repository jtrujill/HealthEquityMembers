IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HealthEquity')
BEGIN
  CREATE DATABASE HealthEquity;
END;
GO
