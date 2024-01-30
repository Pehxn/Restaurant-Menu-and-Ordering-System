
SELECT TOP (1000) [Fullname]
      ,[username]
      ,[pass]
      ,[age]
      ,[gender]
  FROM [resturant].[dbo].[adminLogin]

  delete from adminLogin where username='';