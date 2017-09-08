
select sum(births) a, month(sexdate) from maxmonths 
where country  in (select id from Countries n where n.WinterJul=0)
 group by month(sexdate) order by a desc