  
select b.* into MaxMonths from BirthsMonthly as b inner join
(select max(a.Births) births, a.Year, a.Country from BirthsMonthly as a  
where a.Births > 5000
group by a.Year, a.Country) as c on b.Births = c.births and b.Country = c.Country and b.Year = c.Year
