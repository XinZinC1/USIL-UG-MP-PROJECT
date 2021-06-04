
-- TABLA CLIENTES

ALTER TABLE cliente
ADD CONSTRAINT pk_cliente_id PRIMARY KEY (id_cliente),
    CONSTRAINT un_cliente_dni UNIQUE (dni),
    CONSTRAINT un_cliente_celular UNIQUE (celular),
    CONSTRAINT un_cliente_email UNIQUE (email);
GO

-- TABLA UBICACION

ALTER TABLE ubicacion
ADD CONSTRAINT pk_ubicacion_id PRIMARY KEY (id_ubicacion);
GO

-- TABLA ESPECIALISTAS

ALTER TABLE especialista
ADD CONSTRAINT pk_especialista_id PRIMARY KEY (id_especialista),
    CONSTRAINT fk_especialista_ubicacion FOREIGN KEY (id_ubicacion) REFERENCES ubicacion(id_ubicacion);
GO

-- TABLA ASUNTOS DE CITAS

ALTER TABLE asunto_cita
ADD CONSTRAINT pk_asunto_id PRIMARY KEY (id_asunto),
    CONSTRAINT fk_asunto_especialista FOREIGN KEY (id_especialista) REFERENCES especialista(id_especialista);
GO

-- TABLAS MÉTODOS DE PAGO

ALTER TABLE metodo_pago
ADD CONSTRAINT pk_metodo_id PRIMARY KEY (id_metodo);
GO

-- TABLA CITAS

ALTER TABLE cita
ADD CONSTRAINT pk_cita_id PRIMARY KEY (id_cita),
    CONSTRAINT un_cita_fecha UNIQUE (fecha),
    CONSTRAINT fk_cita_paciente FOREIGN KEY (id_paciente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_cita_asunto FOREIGN KEY (id_asunto) REFERENCES asunto_cita(id_asunto),
    CONSTRAINT fk_cita_metodo FOREIGN KEY (id_metodo) REFERENCES metodo_pago(id_metodo);
GO

-- TABLA BOLETAS DE CITAS

ALTER TABLE boleta_cita
ADD CONSTRAINT pk_boleta_id PRIMARY KEY (id_boleta),
    CONSTRAINT fk_boleta_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_boleta_cita FOREIGN KEY (id_cita) REFERENCES cita(id_cita);
GO

-- TABLA DIAGNOSTICOS DE CITAS

ALTER TABLE diagnostico_cita

ADD CONSTRAINT pk_diagnostico_id PRIMARY KEY (id_diagnostico),
    CONSTRAINT fk_diagnostico_cita FOREIGN KEY (id_cita) ReFERENCES cita(id_cita);
GO

-- TABLA HISTORIALES CLINICOS

ALTER TABLE historial_clinico
ADD CONSTRAINT pk_historial_id PRIMARY KEY (id_historial),
    CONSTRAINT fk_historial_diagnostico FOREIGN KEY (id_diagnostico) REFERENCES diagnostico_cita (id_diagnostico);
GO
