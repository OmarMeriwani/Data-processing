
MERGE Countries  AS T
USING ISOCodes AS S
ON (S.Country like '%' + T.title + '%' and T.ISOCode is null) 
WHEN MATCHED 
    THEN UPDATE SET T.ISOCode = S.ISOCode;

