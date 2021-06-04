
-- CREACIÓN DE LA BASE DE DATOS

CREATE DATABASE bdkinema
GO

-- ESTABLECIMIENTO DE LA BASE DE DATOS

USE bdkinema
GO

-- TABLA CLIENTES

create table cliente
(
    id_cliente int not null, -- PRIMARY KEY
    dni int NOT NULL, -- UNIQUE
    celular int NOT NULL, -- UNIQUE
    email nchar(24) NOT NULL -- UNIQUE
);

GO

ALTER TABLE cliente
ADD CONSTRAINT pk_cliente_id PRIMARY KEY (id_cliente),
    CONSTRAINT un_cliente_dni UNIQUE (dni),
    CONSTRAINT un_cliente_celular UNIQUE (celular),
    CONSTRAINT un_cliente_email UNIQUE (email);

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

ALTER TABLE ubicacion
ADD CONSTRAINT pk_ubicacion_id PRIMARY KEY (id_ubicacion);

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

ALTER TABLE especialista
ADD CONSTRAINT pk_especialista_id PRIMARY KEY (id_especialista),
CONSTRAINT fk_especialista_ubicacion FOREIGN KEY (id_ubicacion) REFERENCES ubicacion(id_ubicacion);
GO

-- TABLA ASUNTOS DE CITAS

create table asunto_cita
(
    id_asunto int not null, -- PRIMARY KEY
    precio decimal(5,2) NOT NULL,
    id_especialista int not null -- FOREIGN KEY

);

GO

ALTER TABLE asunto_cita
ADD CONSTRAINT pk_asunto_id PRIMARY KEY (id_asunto),
    CONSTRAINT fk_asunto_especialista FOREIGN KEY (id_especialista) REFERENCES especialista(id_especialista);

GO

-- TABLAS MÉTODOS DE PAGO

create table metodo_pago
(
    id_metodo int not null, -- PRIMARY KEY
    empresa varchar(12) NOT NULL,
    descripcion varchar(24) NOT NULL
);

GO

ALTER TABLE metodo_pago
ADD CONSTRAINT pk_metodo_id PRIMARY KEY (id_metodo);

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

ALTER TABLE cita
ADD CONSTRAINT pk_cita_id PRIMARY KEY (id_cita),
    CONSTRAINT un_cita_fecha UNIQUE (fecha),
    CONSTRAINT fk_cita_paciente FOREIGN KEY (id_paciente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_cita_asunto FOREIGN KEY (id_asunto) REFERENCES asunto_cita(id_asunto),
    CONSTRAINT fk_cita_metodo FOREIGN KEY (id_metodo) REFERENCES metodo_pago(id_metodo);

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

ALTER TABLE boleta_cita
ADD CONSTRAINT pk_boleta_id PRIMARY KEY (id_boleta),
    CONSTRAINT fk_boleta_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_boleta_cita FOREIGN KEY (id_cita) REFERENCES cita(id_cita);

GO

-- TABLA DIAGNOSTICOS DE CITAS

create table diagnostico_cita
(
    id_diagnostico int not null, -- PRIMARY KEY
    descripcion varchar(48) NOT NULL,
    id_cita int NOT NULL -- FOREIGN KEY
);

GO

ALTER TABLE diagnostico_cita

ADD CONSTRAINT pk_diagnostico_id PRIMARY KEY (id_diagnostico),
    CONSTRAINT fk_diagnostico_cita FOREIGN KEY (id_cita) ReFERENCES cita(id_cita);

GO

-- TABLA HISTORIALES CLINICOS

create table historial_clinico
(
    id_historial int not null, -- PRIMARY KEY
    fecha_creacion date not null,
    id_diagnostico int not null -- FOREIGN KEY
);

GO

ALTER TABLE historial_clinico
ADD CONSTRAINT pk_historial_id PRIMARY KEY (id_historial),
    CONSTRAINT fk_historial_diagnostico FOREIGN KEY (id_diagnostico) REFERENCES diagnostico_cita (id_diagnostico);

GO
