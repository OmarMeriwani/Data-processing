update maxmonths set birthsdate = CAST(convert(char, Year) + '-' + convert (char , Month) +  '-' + '01 ' as date     )

update maxmonths set sexdate = DATEADD(day, -280, BirthsDate)
