CREATE TABLE customer (
    customer_id           INTEGER NOT NULL identity,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
    email        VARCHAR(30) NOT NULL
);


CREATE TABLE brand (
	brand_id	 INTEGER NOT NULL identity,
    name		 VARCHAR(12) NOT NULL
);

CREATE TABLE employee (
    employee_id           INTEGER NOT NULL identity,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
    email        VARCHAR(30) NOT NULL
);
CREATE TABLE shoe (
    shoe_id      INTEGER NOT NULL identity,
    name         VARCHAR(20) NOT NULL,
    size		 INTEGER NOT NULL,
    description  VARCHAR(200) NOT NULL,
    price        INTEGER NOT NULL,
	customer_id  INTEGER NOT NULL,
	brand_id	 INTEGER NOT NULL,
	supplier_id  INTEGER NOT NULL

);

CREATE TABLE cart (
	cart_id		INTEGER NOT NULL identity,
	quantity	INTEGER NOT NULL,
	shoe_id		INTEGER NOT NULL
);

CREATE TABLE supplier (
	supplier_id	 INTEGER NOT NULL identity,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
);

CREATE TABLE payment (
	cart_id		INTEGER NOT NULL,
	type		VARCHAR(10) NOT NULL
);

CREATE TABLE guest (
    customer_id         INTEGER NOT NULL,
	employee_id			INTEGER NOT NULL
);

ALTER TABLE customer ADD CONSTRAINT customer_pk PRIMARY KEY ( customer_id );
ALTER TABLE cart ADD CONSTRAINT cart_pk PRIMARY KEY ( cart_id );
ALTER TABLE employee ADD CONSTRAINT employee_pk PRIMARY KEY ( employee_id );
ALTER TABLE shoe ADD CONSTRAINT shoe_pk PRIMARY KEY ( shoe_id );
ALTER TABLE payment ADD CONSTRAINT payment_pk PRIMARY KEY ( cart_id );
ALTER TABLE supplier ADD CONSTRAINT supplier_pk PRIMARY KEY ( supplier_id );
ALTER TABLE brand ADD CONSTRAINT brand_pk PRIMARY KEY ( brand_id );
ALTER TABLE guest ADD CONSTRAINT guest_pk PRIMARY KEY ( customer_id, employee_id );


ALTER TABLE shoe
    ADD CONSTRAINT customer_shoe_fk FOREIGN KEY ( customer_id )
        REFERENCES customer ( customer_id );
ALTER TABLE shoe
    ADD CONSTRAINT brand_shoe_fk FOREIGN KEY ( brand_id )
        REFERENCES brand ( brand_id );
ALTER TABLE shoe
    ADD CONSTRAINT supplier_shoe_fk FOREIGN KEY ( supplier_id )
        REFERENCES supplier ( supplier_id );
ALTER TABLE cart
    ADD CONSTRAINT shoe_cart_fk FOREIGN KEY ( shoe_id )
        REFERENCES shoe ( shoe_id );
ALTER TABLE payment
    ADD CONSTRAINT cart_payment_fk FOREIGN KEY ( cart_id )
        REFERENCES cart ( cart_id );
ALTER TABLE guest
    ADD CONSTRAINT customer_guest_fk FOREIGN KEY ( customer_id )
        REFERENCES customer( customer_id );
ALTER TABLE guest
    ADD CONSTRAINT employee_guest_fk FOREIGN KEY ( employee_id )
        REFERENCES employee ( employee_id );


insert into customer values ('Tuan','Ostrava',0939875873,'tuantoi1000@gmail.com');
insert into customer values ('Chu','Ostrava',028124121,'tua4dwa1000@gmail.com');
insert into customer values ('Tho','Zlin',091824122,'Th0r@gmail.com');

insert into brand values ('Nike');
insert into brand values ('Addidas');
insert into brand values ('Bitis');
insert into brand values ('Vans');

insert into supplier values ('Evergreen','Prague',777581920);
insert into supplier values ('AMA','Moravia',777241537);
insert into supplier values ('Instaof','Karlovy Vary',777121851);
insert into supplier values ('Mongo','Zlin',777527051);

insert into employee values ('Long','Tokyo',0931824102,'longlanh@gmail.com');
insert into employee values ('Chau','Hanoi',0918312414,'chautho@gmail.com');
insert into employee values ('Bang','HCM',091837721,'bangbang@gmail.com');

insert into shoe values ('Airmax 192',12,'Big size, full color',50,1,1,1);
insert into shoe values ('Hunter Red',11,'Big size, full color',25,2,4,3);

delete from supplier where supplier_id = (selec

select * from supplier where supplier_id = (select shoe_id from shoe where supplier_id = 4);
select * from supplier where supplier_id = 3
select * from shoe where supplier_id = 3

delete * from shoe where supplier_id = 3
delete * from supplier where supplier_id = 3

update supplier set name = 'AMA', address ='Berlin', telephone = 774117538 where supplier_id = 2

select * from supplier

delete from shoe where shoe_id = 3
select * from shoe
insert into cart values (26,1);
insert into cart values (5,2);

insert into payment values (1,'Card');
insert into payment values (2,'Cash');

insert into guest values (1,1);

ALTER TABLE shoe
DROP CONSTRAINT customer_shoe_fk;
ALTER TABLE shoe
DROP CONSTRAINT brand_shoe_fk;
ALTER TABLE shoe
DROP CONSTRAINT supplier_shoe_fk;
ALTER TABLE cart
DROP CONSTRAINT shoe_cart_fk;
ALTER TABLE payment
DROP CONSTRAINT cart_payment_fk;
ALTER TABLE guest
DROP CONSTRAINT customer_guest_fk;
ALTER TABLE guest
DROP CONSTRAINT employee_guest_fk;

ALTER TABLE customer
DROP CONSTRAINT customer_pk;
ALTER TABLE cart
DROP CONSTRAINT cart_pk;
ALTER TABLE employee
DROP CONSTRAINT employee_pk;
ALTER TABLE shoe
DROP CONSTRAINT shoe_pk;
ALTER TABLE payment
DROP CONSTRAINT payment_pk;
ALTER TABLE supplier
DROP CONSTRAINT supplier_pk;
ALTER TABLE brand
DROP CONSTRAINT brand_pk;
ALTER TABLE guest
DROP CONSTRAINT guest_pk;

DROP TABLE brand;
DROP TABLE cart;
DROP TABLE customer;
DROP TABLE employee;
DROP TABLE guest;
DROP TABLE payment;
DROP TABLE shoe;
DROP TABLE supplier;
