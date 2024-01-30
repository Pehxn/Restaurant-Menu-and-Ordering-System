/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Name]
      ,[Address]
      ,[Contact_No]
      ,[Total]
  FROM [resturant].[dbo].[Place_Order_Detail]