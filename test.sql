;with cte as (
		select [CustomerId], min([DateCreated]) as mindate
	    from Sales group by [CustomerId])
select [ProductId], cte.[CustomerId],[DateCreated]
from Sales s inner join cte 
on s.[CustomerId] = cte.[CustomerId] and s.[DateCreated] = cte.mindate;