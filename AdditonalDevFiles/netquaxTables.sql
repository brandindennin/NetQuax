CREATE TABLE USERS(
  userID NUMBER(5) PRIMARY KEY,
  userName VARCHAR(20) NOT NULL,
  userPassword VARCHAR(10) NOT NULL,
  isAdmin NUMBER(2) NOT NULL,
  userAddressID NUMBER(10),
  userTypeID NUMBER(3) NOT NULL,
  userCCInfo NUMBER(16)
  );

CREATE TABLE ADDRESSES(
  addressID NUMBER(5) PRIMARY KEY,
  addressLineOne NUMBER(10),
  addressLineTwo VARCHAR(30),
  cityAndState VARCHAR (40),
  zipCode NUMBER(5),
  userID NUMBER(5),
  FOREIGN KEY (userID) REFERENCES USERS(userID)
  );
  
CREATE TABLE USERTYPES(
   userTypeID NUMBER(3) PRIMARY KEY,
   nameOfType VARCHAR(20) NOT NULL,
   rentalAmount NUMBER(10) NOT NULL
   );
   
CREATE TABLE CREDITCARD(
   creditCardNumber NUMBER(16) PRIMARY KEY,
   cnn NUMBER(3),
   experationDate date default (sysdate),
   issuer VARCHAR(20),
   billingAddressID NUMBER(5),
   addID NUMBER(5),
   FOREIGN KEY (addID) REFERENCES ADDRESSES(addressID)
   );
   
   
CREATE TABLE MOVIES(
   movieID VARCHAR(40) PRIMARY KEY,
   nameOfMovie VARCHAR(50) NOT NULL,
   description VARCHAR(140) NOT NULL,
   director VARCHAR(30) NOT NULL,
   genre VARCHAR(20) NOT NULL,
   actors VARCHAR(100) NOT NULL,
   yearReleased NUMBER(4) NOT NULL,
   rating NUMBER(5),
   movieMode VARCHAR(4) NOT NULL,
   price DECIMAL(5) NOT NULL,
   userTypeID NUMBER(3) NOT NULL,
   FOREIGN KEY (userTypeID) REFERENCES USERTYPES(userTypeID)
   );
 
   
   
   
   