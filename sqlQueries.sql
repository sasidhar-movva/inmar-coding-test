1.select * from customer where name like 'Joe%';

2. select p.name from product p inner join orderproduct op on op.productid = p.productid 
inner join order o on o.orderid = op.orderid where  o.cretaedat > to_Date("11/1/2016");

3.select sum(p.price) from csutomer c 
inner join order o on o.customerid = c.customerid
inner join orderprodcut op on op.orderid = o.orderid
inner join product p on p.productid = op.productid
where c.name = "Joe";

4. select name, count(p.order) from csutomer c 
inner join order o on o.customerid = c.customerid
inner join orderprodcut op on op.orderid = o.orderid
inner join product p on p.productid = op.productid
group by c.name
