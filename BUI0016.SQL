CREATE TABLE customer (
    customer_id           INTEGER NOT NULL identity,
    login        VARCHAR(10) NOT NULL,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
    email        VARCHAR(30) NOT NULL
);
CREATE TABLE shift (
    shift_id           INTEGER NOT NULL identity,
	type			   VARCHAR(12) NOT NULL
);
CREATE TABLE driver (
    driver_id           INTEGER NOT NULL identity,
    login        VARCHAR(10) NOT NULL,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
    email        VARCHAR(30) NOT NULL,
	shift_id	 INTEGER NOT NULL
);
CREATE TABLE staff (
    staff_id     INTEGER NOT NULL identity,
    login        VARCHAR(10) NOT NULL,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
    email        VARCHAR(30) NOT NULL,
);
CREATE TABLE car (
    car_id       INTEGER NOT NULL identity,
	brand		 VARCHAR(20) NOT NULL,
	name		 VARCHAR(20) NOT NULL,
	color		 VARCHAR(10) NOT NULL,
	type		 VARCHAR(20) NOT NULL,
	driver_id	 INTEGER NOT NULL,

);
CREATE TABLE booking (
    booking_id      INTEGER NOT NULL identity,
	requirements	VARCHAR(200) NOT NULL,
	car_id			INTEGER NOT NULL,
	customer_id		INTEGER NOT NULL

);
CREATE TABLE payment (
    payment_id           INTEGER NOT NULL identity,
	booking_id      INTEGER NOT NULL

);
CREATE TABLE company (
    driver_id           INTEGER NOT NULL,
	staff_id            INTEGER NOT NULL,
	car_id              INTEGER NOT NULL
);

CREATE TABLE person (
customer_id         INTEGER NOT NULL,
driver_id           INTEGER NOT NULL,
staff_id            INTEGER NOT NULL
);
/*CREATE TABLE admins (
    admins_id           INTEGER NOT NULL identity,
    login        VARCHAR(10) NOT NULL,
    name         VARCHAR(20) NOT NULL,
    address		 VARCHAR(30) NOT NULL,
    telephone    INTEGER NOT NULL,
    email        VARCHAR(30) NOT NULL
);
ALTER TABLE admins ADD CONSTRAINT admin_pk PRIMARY KEY ( admins_id );*/

ALTER TABLE customer ADD CONSTRAINT customer_pk PRIMARY KEY ( customer_id );
ALTER TABLE shift ADD CONSTRAINT shift_pk PRIMARY KEY ( shift_id );
ALTER TABLE driver ADD CONSTRAINT driver_pk PRIMARY KEY ( driver_id );
ALTER TABLE staff ADD CONSTRAINT staff_pk PRIMARY KEY ( staff_id );
ALTER TABLE car ADD CONSTRAINT car_pk PRIMARY KEY ( car_id );
ALTER TABLE booking ADD CONSTRAINT booking_pk PRIMARY KEY ( booking_id );
ALTER TABLE payment ADD CONSTRAINT payment_pk PRIMARY KEY ( payment_id );
ALTER TABLE company ADD CONSTRAINT company_pk PRIMARY KEY ( car_id, driver_id, staff_id );
ALTER TABLE person ADD CONSTRAINT person_pk PRIMARY KEY ( customer_id, driver_id, staff_id);

ALTER TABLE company
    ADD CONSTRAINT car_company_fk FOREIGN KEY ( car_id )
        REFERENCES car ( car_id );
ALTER TABLE company
    ADD CONSTRAINT driver_company_fk FOREIGN KEY ( driver_id )
        REFERENCES driver ( driver_id );
ALTER TABLE company
    ADD CONSTRAINT staff_company_fk FOREIGN KEY ( staff_id )
        REFERENCES staff ( staff_id );

ALTER TABLE driver
	ADD CONSTRAINT shift_driver_fk FOREIGN KEY ( shift_id )
        REFERENCES shift ( shift_id );

ALTER TABLE person
    ADD CONSTRAINT customer_person_fk FOREIGN KEY ( customer_id )
        REFERENCES customer ( customer_id );
ALTER TABLE person
    ADD CONSTRAINT driver_person_fk FOREIGN KEY ( driver_id )
        REFERENCES driver ( driver_id );
ALTER TABLE person
    ADD CONSTRAINT staff_person_fk FOREIGN KEY ( staff_id )
        REFERENCES staff ( staff_id );


ALTER TABLE car
    ADD CONSTRAINT driver_car_fk FOREIGN KEY ( driver_id )
        REFERENCES driver ( driver_id );

ALTER TABLE booking
    ADD CONSTRAINT car_booking_fk FOREIGN KEY ( car_id )
        REFERENCES car ( car_id );

ALTER TABLE booking
    ADD CONSTRAINT customer_booking_fk FOREIGN KEY ( customer_id )
        REFERENCES customer ( customer_id );

ALTER TABLE payment
    ADD CONSTRAINT booking_payment_fk FOREIGN KEY ( booking_id )
        REFERENCES booking ( booking_id );

insert into customer values ('bui0016', 'tuan vu', 'Ostrava', 777987097, 'bui0016@vsb.cz');
insert into customer values ('ngon211','nguyen thai', 'Prague', 821921251, 'ngon211@vsb.cz');
insert into customer values ('fos122', 'Fosibler Allan', 'Zlin', 311920245, 'fos122@vsb.cz');

insert into shift values ('Morning');
insert into shift values ('Afternoon');
insert into shift values ('Evening');

insert into driver values ('lol921', 'martin', 'Ostrava', 727927387, 'martin@vsb.cz',1);
insert into driver values ('fgn391', 'Fargin', 'Prague', 821923091, 'fgn@taxi.cz',2);
insert into driver values ('mmi9', 'Mouxz', 'Zlin', 311912451, 'mmi9@taxi.cz',3);

insert into staff values ('tam214', 'tam nguyen', 'Ostrava', 609621478, 'tamnguyen@vsb.cz');
insert into car  values ('VINASUN','77R2-12034','Red','4 seats',1)
insert into booking  values ('4  seats, handsome taxi',1,1);
insert into payment values (1);	
insert into company values (1,1,1);
insert into person values (1,1,1);


ALTER TABLE booking
DROP CONSTRAINT [car_booking_fk];

ALTER TABLE booking
DROP CONSTRAINT [customer_booking_fk];

ALTER TABLE car
DROP CONSTRAINT [driver_car_fk];

ALTER TABLE company
DROP CONSTRAINT [car_company_fk];

ALTER TABLE company
DROP CONSTRAINT [driver_company_fk];

ALTER TABLE company
DROP CONSTRAINT [staff_company_fk];

ALTER TABLE payment
DROP CONSTRAINT [booking_payment_fk];

ALTER TABLE driver
DROP CONSTRAINT shift_driver_fk;

ALTER TABLE person
DROP CONSTRAINT [customer_person_fk];

ALTER TABLE person
DROP CONSTRAINT [driver_person_fk];

ALTER TABLE person
DROP CONSTRAINT [staff_person_fk];

ALTER TABLE booking
DROP CONSTRAINT [booking_pk];

ALTER TABLE car
DROP CONSTRAINT [car_pk];

ALTER TABLE company
DROP CONSTRAINT [company_pk];

ALTER TABLE shift
DROP CONSTRAINT [shift_pk];

ALTER TABLE customer
DROP CONSTRAINT [customer_pk];

ALTER TABLE driver
DROP CONSTRAINT [driver_pk];

ALTER TABLE payment
DROP CONSTRAINT [payment_pk];

ALTER TABLE person
DROP CONSTRAINT [person_pk];

ALTER TABLE staff
DROP CONSTRAINT [staff_pk];

DROP TABLE booking
DROP TABLE car
DROP TABLE company
DROP TABLE customer
DROP TABLE driver
DROP TABLE payment
DROP TABLE person
DROP TABLE staff
DROP TABLE shift
