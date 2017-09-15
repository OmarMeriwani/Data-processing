
select sum(births) a, month(sexdate) from maxmonths 
where country  in (select id from Countries n where n.WinterJul=0) and  
 group by month(sexdate) order by a desc

 select c.title, d.* from countries as c  join annualtemp  as d on c.ISOCode = d.ISOCode order by d.AnnualTemp

 select f.title, g.* from Countries as f join AnnualTemp as g on f.ISOCode=g.ISOCode where f.WinterJul =  'TRUE'

 select * from annualtemp