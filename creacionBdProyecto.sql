CREATE TABLE categoria
(
 id int NOT NULL PRIMARY KEY,
 nombre_cat VARCHAR(30) not null
 );

CREATE TABLE proveedores
(
  	id int NOT NULL PRIMARY KEY,
	nombre_p VARCHAR (30) not null,
	direccion_p VARCHAR (30) not null,
	medio_de_pago_p float not null 	
);

CREATE TABLE producto
(
  	id int NOT NULL PRIMARY KEY,
	nombre VARCHAR(30) not null,
	descripcion VARCHAR(30) not null,
	p_costo FLOAT not null,
	p_venta FLOAT not null,
	stock INT,
    categoria_id INT,
    proveedor_id INT,
    foreign key (categoria_id) references categoria (id), 
    foreign key (proveedor_id) references proveedores (id)
)

CREATE TABLE usuarios(
id int NOT NULL PRIMARY KEY,
nombre VARCHAR(30) not null,
apellido VARCHAR(30) not null,
mail VARCHAR(50) not null,
usuario VARCHAR(15) not null,
contraseña VARCHAR(15) not null,
)

