﻿SELECT *, ntile(4)  OVER (PARTITION BY AnnualTemp   ORDER BY  AnnualTemp) as rank FROM AnnualTemp as p order by rank