delete from BirthsMonthly  where id in (
select id from BirthsMonthly as b join 
(select count(a.Month) as cc, a.Country, a.Year from BirthsMonthly as a  group by a.Country, a.Year
having count(*) < 12) as  c on b.Country = c.Country and b.Year = c.Year)