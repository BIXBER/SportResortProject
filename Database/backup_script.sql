CREATE TABLE Roles
(
	id SMALLINT CONSTRAINT PK_role_id PRIMARY KEY IDENTITY (1, 1),
	title NVARCHAR(50) UNIQUE NOT NULL,
	description NVARCHAR(200) UNIQUE
);

CREATE TABLE Users
(
	id SMALLINT CONSTRAINT PK_user_id PRIMARY KEY IDENTITY (1, 1),
	username NVARCHAR(50) CONSTRAINT UQ_user_username UNIQUE NOT NULL,
	role_id SMALLINT CONSTRAINT DF_user_role_id DEFAULT 3 NULL,
	email NVARCHAR(200) UNIQUE NOT NULL,
	first_name NVARCHAR(50) NOT NULL,
	last_name NVARCHAR(100) NOT NULL,
	patronymic NVARCHAR(50) NOT NULL,
	passphrase NCHAR(50) NOT NULL,
	gender CHAR(1) CONSTRAINT CK_user_gender CHECK(gender IN ('F', 'M')) NOT NULL,
	CONSTRAINT FK_users_role_id FOREIGN KEY (role_id) REFERENCES Roles(id) ON DELETE SET NULL,
	CONSTRAINT UC_first_name_last_name UNIQUE (first_name, last_name, patronymic)
);

CREATE TABLE Products
(
	id SMALLINT CONSTRAINT PK_product_id PRIMARY KEY IDENTITY (1, 1),
	title NVARCHAR(200) UNIQUE NOT NULL,
	description NVARCHAR(MAX),
	image_path NVARCHAR(200) UNIQUE,
	cost DECIMAL(10, 2) NOT NULL,
	is_available BIT,
);

CREATE TABLE ShoppingCarts
(
	id SMALLINT CONSTRAINT PK_shopping_cart_id PRIMARY KEY IDENTITY (1, 1),
	user_id SMALLINT NOT NULL,
	product_id SMALLINT NOT NULL,
	CONSTRAINT FK_shopping_carts_user_id FOREIGN KEY (user_id) REFERENCES Users(id) ON DELETE CASCADE,
	CONSTRAINT FK_shopping_carts_product_id FOREIGN KEY (product_id) REFERENCES Products(id) ON DELETE CASCADE
);

CREATE TABLE Orders
(
	id INT CONSTRAINT PK_order_id PRIMARY KEY IDENTITY (1, 1),
	created_at DATETIME NOT NULL,
	user_id SMALLINT NOT NULL,
	product_id SMALLINT NOT NULL,
	count SMALLINT NOT NULL,
	CONSTRAINT FK_orders_user_id FOREIGN KEY (user_id) REFERENCES Users(id) ON DELETE NO ACTION,
	CONSTRAINT FK_orders_product_id FOREIGN KEY (product_id) REFERENCES Products(id) ON DELETE NO ACTION
);