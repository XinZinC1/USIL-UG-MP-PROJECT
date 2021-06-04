
-- TABLA CLIENTES

create table cliente
(
    id_cliente int not null, -- PRIMARY KEY
    dni int NOT NULL, -- UNIQUE
    celular int NOT NULL, -- UNIQUE
    email nchar(24) NOT NULL -- UNIQUE
);

GO

-- TABLA UBICACION

create table ubicacion
(
    id_ubicacion int not null, -- PRIMARY KEY
    region varchar(12) not null,
    ciudad varchar(16) not null,
    direccion varchar(48) not null
);

GO

-- TABLA ESPECIALISTAS

create table especialista
(
    id_especialista int not null, -- PRIMARY KEY
    nombres varchar(36) not null,
    apellidos varchar(24) not null,
    id_ubicacion int not null -- FOREIGN KEY
);

GO

-- TABLA ASUNTOS DE CITAS

create table asunto_cita
(
    id_asunto int not null, -- PRIMARY KEY
    precio decimal(5,2) NOT NULL,
    id_especialista int not null -- FOREIGN KEY

);

GO

-- TABLAS MÉTODOS DE PAGO

create table metodo_pago
(
    id_metodo int not null, -- PRIMARY KEY
    empresa varchar(12) NOT NULL,
    descripcion varchar(24) NOT NULL
);

GO

-- TABLA CITAS

create table cita
(
    id_cita int not null, -- PRIMARY KEY
    fecha date NOT NULL, -- UNIQUE
    id_paciente int NOT NULL, -- FOREIGN KEY
    id_asunto int not null, -- FOREIGN KEY
    id_metodo int NOT NULL -- FOREIGN KEY
);

GO

-- TABLA BOLETAS DE CITAS

create table boleta_cita
(
    id_boleta int not null, -- PRIMARY KEY,
    fecha date not null,
    id_cliente int not null, -- FOREIGN KEY
    id_cita int not null -- FOREIGN KEY
);

GO

-- TABLA DIAGNOSTICOS DE CITAS

create table diagnostico_cita
(
    id_diagnostico int not null, -- PRIMARY KEY
    descripcion varchar(48) NOT NULL,
    id_cita int NOT NULL -- FOREIGN KEY
);

GO

-- TABLA HISTORIALES CLINICOS

create table historial_clinico
(
    id_historial int not null, -- PRIMARY KEY
    fecha_creacion date not null,
    id_diagnostico int not null -- FOREIGN KEY
);

GO
