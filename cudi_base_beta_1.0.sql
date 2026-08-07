-- ============================================================
-- SISTEMA CUDI
-- BASE DE DATOS - VERSION 1.0
-- Primera entrega
-- Compatible con MySQL / MariaDB
-- ============================================================


-- ============================================================
-- 1. CREAR BASE DE DATOS
-- ============================================================

DROP DATABASE IF EXISTS cudi;

CREATE DATABASE cudi
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE cudi;


-- ============================================================
-- 2. ROLES
-- ============================================================

CREATE TABLE roles (

    id_rol INT AUTO_INCREMENT PRIMARY KEY,

    nombre VARCHAR(30) NOT NULL UNIQUE

);


INSERT INTO roles (nombre)
VALUES
('Administrador'),
('Recepcionista');


-- ============================================================
-- 3. USUARIOS DEL SISTEMA
-- ============================================================

CREATE TABLE usuarios (

    id_usuario INT AUTO_INCREMENT PRIMARY KEY,

    nombre VARCHAR(50) NOT NULL,

    apellido VARCHAR(50) NOT NULL,

    usuario VARCHAR(50) NOT NULL UNIQUE,

    contrasena VARCHAR(255) NOT NULL,

    id_rol INT NOT NULL,

    activo BOOLEAN NOT NULL DEFAULT TRUE,

    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (id_rol)
        REFERENCES roles(id_rol)

);


-- Usuario administrador inicial
-- Usuario: admin
-- Contraseña: admin123

INSERT INTO usuarios
(nombre, apellido, usuario, contrasena, id_rol)
VALUES
(
    'Administrador',
    'CUDI',
    'admin',
    'admin123',
    1
);


-- ============================================================
-- 4. CARRERAS
-- ============================================================

CREATE TABLE carreras (

    id_carrera INT AUTO_INCREMENT PRIMARY KEY,

    nombre VARCHAR(150) NOT NULL UNIQUE,

    activo BOOLEAN NOT NULL DEFAULT TRUE

);


INSERT INTO carreras (nombre)
VALUES
('Tecnicatura Universitaria en Desarrollo de Software'),
('Tecnicatura Universitaria en Producción y Desarrollo de Videojuegos'),
('Tecnicatura en Gestión de Tecnologías de la Información y las Comunicaciones'),
('Analista en Ciencias de Datos e IA'),
('Tecnicatura Universitaria en Biotecnología'),
('Tecnicatura Universitaria en Diseño Industrial'),
('Tecnicatura Universitaria en Tecnología de los Alimentos'),
('Enfermería Universitaria'),
('Licenciatura en Bioinformática y Bioingeniería'),
('Licenciatura en Obstetricia');


-- ============================================================
-- 5. PERSONAS
-- ============================================================

CREATE TABLE personas (

    id_persona INT AUTO_INCREMENT PRIMARY KEY,

    dni VARCHAR(15) NOT NULL UNIQUE,

    apellido VARCHAR(50) NOT NULL,

    nombre VARCHAR(50) NOT NULL,

    tipo_persona ENUM(
        'Alumno',
        'Pasante'
    ) NOT NULL,

    id_carrera INT NULL,

    telefono_emergencia VARCHAR(20) NULL,

    activo BOOLEAN NOT NULL DEFAULT TRUE,

    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (id_carrera)
        REFERENCES carreras(id_carrera)

);


-- ============================================================
-- 6. RECURSOS
-- ============================================================

CREATE TABLE recursos (

    id_recurso INT AUTO_INCREMENT PRIMARY KEY,

    tipo ENUM(
        'Computadora',
        'Libro'
    ) NOT NULL,

    estado ENUM(
        'Disponible',
        'Prestado',
        'Mantenimiento',
        'No disponible'
    ) NOT NULL DEFAULT 'Disponible',

    observaciones TEXT NULL,

    activo BOOLEAN NOT NULL DEFAULT TRUE,

    fecha_creacion DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP

);


-- ============================================================
-- 7. COMPUTADORAS
-- ============================================================

CREATE TABLE computadoras (

    id_computadora INT AUTO_INCREMENT PRIMARY KEY,

    id_recurso INT NOT NULL UNIQUE,

    numero_equipo INT NOT NULL,

    tipo ENUM(
        'Notebook',
        'Netbook',
        'Isla'
    ) NOT NULL,

    FOREIGN KEY (id_recurso)
        REFERENCES recursos(id_recurso)
        ON DELETE CASCADE,

    UNIQUE (tipo, numero_equipo)

);


-- ============================================================
-- 8. TITULOS DE LIBROS
-- ============================================================

CREATE TABLE titulos_libros (

    id_titulo INT AUTO_INCREMENT PRIMARY KEY,

    titulo VARCHAR(200) NOT NULL

);


-- ============================================================
-- 9. EJEMPLARES DE LIBROS
-- ============================================================

CREATE TABLE libros (

    id_libro INT AUTO_INCREMENT PRIMARY KEY,

    id_recurso INT NOT NULL UNIQUE,

    id_titulo INT NOT NULL,

    FOREIGN KEY (id_recurso)
        REFERENCES recursos(id_recurso)
        ON DELETE CASCADE,

    FOREIGN KEY (id_titulo)
        REFERENCES titulos_libros(id_titulo)

);


-- ============================================================
-- 10. PRESTAMOS
-- ============================================================

CREATE TABLE prestamos (

    id_prestamo INT AUTO_INCREMENT PRIMARY KEY,

    id_persona INT NOT NULL,

    id_recurso INT NOT NULL,

    id_usuario INT NOT NULL,

    fecha_prestamo DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    fecha_devolucion DATETIME NULL,

    observaciones TEXT NULL,

    FOREIGN KEY (id_persona)
        REFERENCES personas(id_persona),

    FOREIGN KEY (id_recurso)
        REFERENCES recursos(id_recurso),

    FOREIGN KEY (id_usuario)
        REFERENCES usuarios(id_usuario)

);


-- ============================================================
-- 11. HISTORIAL
-- ============================================================

CREATE TABLE historial (

    id_historial INT AUTO_INCREMENT PRIMARY KEY,

    id_prestamo INT NOT NULL UNIQUE,

    estado_devolucion ENUM(
        'Bueno',
        'Regular',
        'Dañado'
    ) NULL,

    observaciones TEXT NULL,

    fecha_registro DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (id_prestamo)
        REFERENCES prestamos(id_prestamo)

);


-- ============================================================
-- DATOS DE PRUEBA
-- ============================================================


-- ------------------------------------------------------------
-- PERSONAS DE PRUEBA
-- ------------------------------------------------------------

INSERT INTO personas
(dni, apellido, nombre, tipo_persona, id_carrera, telefono_emergencia)
VALUES
(
    '45123456',
    'Medina',
    'Pedro',
    'Alumno',
    1,
    '1123456789'
),
(
    '48510869',
    'Nuñez',
    'Florencia',
    'Alumno',
    10,
    '1127001464'
),
(
    '41713600',
    'Nuñez',
    'Soledad',
    'Alumno',
    6,
    '1138735366'
),
(
    '41851619',
    'Costas',
    'Blanca Luz',
    'Pasante',
    NULL,
    '1138735366'
);


-- ------------------------------------------------------------
-- RECURSOS DE PRUEBA
-- ------------------------------------------------------------

-- Computadora
INSERT INTO recursos (tipo, estado, observaciones)
VALUES
('Computadora', 'Disponible', NULL);

INSERT INTO computadoras
(id_recurso, numero_equipo, tipo)
VALUES
(LAST_INSERT_ID(), 1, 'Notebook');


-- Computadora
INSERT INTO recursos (tipo, estado, observaciones)
VALUES
('Computadora', 'Disponible', NULL);

INSERT INTO computadoras
(id_recurso, numero_equipo, tipo)
VALUES
(LAST_INSERT_ID(), 2, 'Notebook');


-- Computadora
INSERT INTO recursos (tipo, estado, observaciones)
VALUES
('Computadora', 'Disponible', NULL);

INSERT INTO computadoras
(id_recurso, numero_equipo, tipo)
VALUES
(LAST_INSERT_ID(), 1, 'Netbook');


-- Computadora
INSERT INTO recursos (tipo, estado, observaciones)
VALUES
('Computadora', 'Disponible', NULL);

INSERT INTO computadoras
(id_recurso, numero_equipo, tipo)
VALUES
(LAST_INSERT_ID(), 1, 'Isla');


-- ------------------------------------------------------------
-- LIBROS DE PRUEBA
-- ------------------------------------------------------------

INSERT INTO titulos_libros (titulo)
VALUES
('Python 1'),
('Python 2'),
('Biología'),
('Videojuegos');


-- Ejemplar 1
INSERT INTO recursos (tipo, estado)
VALUES
('Libro', 'Disponible');

INSERT INTO libros
(id_recurso, id_titulo)
VALUES
(LAST_INSERT_ID(), 1);


-- Ejemplar 2
INSERT INTO recursos (tipo, estado)
VALUES
('Libro', 'Disponible');

INSERT INTO libros
(id_recurso, id_titulo)
VALUES
(LAST_INSERT_ID(), 1);


-- Ejemplar 3
INSERT INTO recursos (tipo, estado)
VALUES
('Libro', 'Disponible');

INSERT INTO libros
(id_recurso, id_titulo)
VALUES
(LAST_INSERT_ID(), 2);


-- Ejemplar 4
INSERT INTO recursos (tipo, estado)
VALUES
('Libro', 'Disponible');

INSERT INTO libros
(id_recurso, id_titulo)
VALUES
(LAST_INSERT_ID(), 3);


-- Ejemplar 5
INSERT INTO recursos (tipo, estado)
VALUES
('Libro', 'Disponible');

INSERT INTO libros
(id_recurso, id_titulo)
VALUES
(LAST_INSERT_ID(), 4);


-- ============================================================
-- FIN DEL SCRIPT
-- ============================================================


-- CONSULTAS DE COMPROBACION
-- Pueden ejecutarse después de importar el script.

SELECT * FROM roles;

SELECT * FROM usuarios;

SELECT * FROM carreras;

SELECT * FROM personas;

SELECT * FROM recursos;

SELECT * FROM computadoras;

SELECT * FROM titulos_libros;

SELECT * FROM libros;

SELECT * FROM prestamos;

SELECT * FROM historial;