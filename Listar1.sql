create proc Listar1 
(
	 @dtini as Datetime
	,@dtfim as Datetime
)
as begin
	create table #tmp1 (
		conta char(15) not null,
		descr varchar(50) not null,
		saldo numeric(18,3) default 0
	)
	create index tmp1_idx1 on #tmp1 (conta asc)
	
	insert into #tmp1
	select distinct a.conta, a.descr,0 from contas a, lancamento b
	where a.conta=b.conta and b.data between @dtini and @dtfim
	
	update a
	set a.saldo = ( select coalesce(SUM(b.amount),0) from lancamento b where b.conta=a.conta and b.data<=@dtfim )
	from #tmp1 a
	
	select conta, descr, saldo from #tmp1 order by 1
end
go
