USE NetQuax

CREATE TABLE USERS(
  userId BIGINT IDENTITY(1,1) PRIMARY KEY,
  userName VARCHAR(20) NULL,
  userPassword VARCHAR(10) NULL,
  isAdmin BIT NULL,
  userAddressId BIGINT,
  userTypeId BIGINT NULL,
  userCCInfoId BIGINT
  );

CREATE TABLE ADDRESSES(
  addressId BIGINT IDENTITY(1,1) PRIMARY KEY,
  addressLineOne VARCHAR(50),
  addressLineTwo VARCHAR(30),
  city VARCHAR (40),
  state VARCHAR (40),
  zipCode BIGINT,
  userId BIGINT,  
  );
  
CREATE TABLE USERTYPES(
   userTypeId BIGINT IDENTITY(1,1) PRIMARY KEY,
   nameOfType VARCHAR(20) NULL,
   rentalAmount BIGINT NULL
   );
   
  

CREATE TABLE CREDITCARD(
   creditCardId BIGINT IDENTITY(1,1) PRIMARY KEY,
   creditCardNumber VARCHAR (50),
   expirationDate DATETIME,
   CVV BIGINT,
   issuer VARCHAR(20),
	billingAddressId BIGINT,
   addressId BIGINT,   
  );
   
   
CREATE TABLE MOVIES(
   movieId BIGINT IDENTITY(1,1) PRIMARY KEY,
   nameOfMovie VARCHAR(50) NULL,
   Description VARCHAR(140) NULL,
   director VARCHAR(30) NULL,
   genre VARCHAR(20) NULL,
   actors VARCHAR(100) NULL,
   yearReleased BIGINT NULL,
   rating BIGINT,
   movieMode VARCHAR(4) NULL,
   price DECIMAL(5) NULL,
   userTypeId BIGINT NULL,
  
   );
 
   
   
   
   