MERGE BirthsMonthly AS T
USING Countries AS S
ON (T.Country = S.title) 
WHEN MATCHED 
    THEN UPDATE SET T.Country = S.id;

MERGE MaxMonths AS T
USING Countries AS S
ON (T.Country = S.title) 
WHEN MATCHED 
    THEN UPDATE SET T.Country = S.id;
