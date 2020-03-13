use pizzaboxdb;
go

--select 
select name from crusts
where price > 0
group by name, price HAVING price > 1.50 order by name asc;

--Order of execution
-- FROM
-- WHERE
-- GROUP BY
-- HAVING
-- SELECT 
-- ORDER BY

select * from person.person;

