1.select * from customer where name like 'Joe%';
2. select p.name from product p inner join orderproduct op on op.productid = p.productid 
inner join order o on o.orderid = op.orderid where  o.cretaedat > to_Date("11/1/2016");

3.select sum(p.price) from csutomer c 
inner join order o on o.customerid = c.customerid
inner join product p on p.productid = 
