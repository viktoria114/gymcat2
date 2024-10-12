-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-10-2024 a las 02:41:08
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gymcat`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `año`
--

CREATE TABLE `año` (
  `ID_año` int(11) NOT NULL,
  `numero` int(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `año`
--

INSERT INTO `año` (`ID_año`, `numero`) VALUES
(1, 2024);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos`
--

CREATE TABLE `cursos` (
  `ID_cursos` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `horario` varchar(50) NOT NULL,
  `precio` int(10) NOT NULL,
  `dias_clase` varchar(50) NOT NULL,
  `FK_empleados` int(11) DEFAULT NULL,
  `turno` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `cursos`
--

INSERT INTO `cursos` (`ID_cursos`, `nombre`, `horario`, `precio`, `dias_clase`, `FK_empleados`, `turno`) VALUES
(1, 'Pilates', '18:00 20:00', 6500, 'martes, jueves', 2, 'Tarde'),
(2, 'Yoga', '20:00 22:00', 7000, 'sábados', 6, 'Tarde'),
(3, 'Funcional', '9:00 11:00', 5000, 'lunes, miércoles, viernes', 5, 'Mañana'),
(4, 'Boxeo', '20:00 22:00', 5000, 'lunes, miércoles, viernes', 5, 'Tarde'),
(5, 'Musculación1', '8:00 10:00', 5000, 'lunes, miércoles', 2, 'Mañana'),
(6, 'Musculación2', '8:00 10:00', 5000, 'martes, jueves, sábado', 5, 'Mañana'),
(7, 'Crossfit', '15:00 17:00', 6500, 'miércoles, viernes', 7, 'Tarde');

--
-- Disparadores `cursos`
--
DELIMITER $$
CREATE TRIGGER `ADD_EVENTO_CURSOS` AFTER INSERT ON `cursos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se agregó un Curso: ', NEW.nombre, ' ID: ', NEW.ID_cursos), NOW());
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_CURSOS` AFTER DELETE ON `cursos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se eliminó un Curso: ', OLD.nombre, ' ID: ', OLD.ID_cursos), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos_elementos_maquinas`
--

CREATE TABLE `cursos_elementos_maquinas` (
  `FK_cursos` int(11) NOT NULL,
  `FK_elementos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `cursos_elementos_maquinas`
--

INSERT INTO `cursos_elementos_maquinas` (`FK_cursos`, `FK_elementos`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos_mes_ingresos`
--

CREATE TABLE `cursos_mes_ingresos` (
  `FK_cursos` int(11) NOT NULL,
  `FK_mes` int(11) NOT NULL,
  `FK_ingresos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `elementos deportivos`
--

CREATE TABLE `elementos deportivos` (
  `ID_elementos_deportivos` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `precio` int(20) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `fecha_compra` date NOT NULL,
  `stock` int(20) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `detalle` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `elementos deportivos`
--

INSERT INTO `elementos deportivos` (`ID_elementos_deportivos`, `nombre`, `modelo`, `precio`, `tipo`, `fecha_compra`, `stock`, `marca`, `estado`, `detalle`) VALUES
(1, 'Caminadora', '780', 1, 'Máquina', '2024-07-22', 1, 'Enerfit', 'Nuevo', 'es pa caminar'),
(2, 'Mancuernas', 'Recubierta', 10000, 'cromadas', '2023-03-01', 10, 'Reebok', 'Correcto', ''),
(3, 'Bandas elásticas', 'Tubulares', 15000, 'Ligeras', '2024-06-27', 4, 'TheraBand', 'Desgastados', ''),
(4, 'Cuerdas para saltar', 'Ajustable', 5000, 'PVC', '2019-08-17', 13, 'Decathlon', 'Viejo', ''),
(5, 'pesa', 'ena', 555, 'no se', '2024-08-27', 2, 'fiumba', 'Nuevo', 's');

--
-- Disparadores `elementos deportivos`
--
DELIMITER $$
CREATE TRIGGER `ADD_EVENTO_ELEMENTOS_DEPORTIVOS` AFTER INSERT ON `elementos deportivos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se agregó el elemento deportivo: ', NEW.nombre, ' ID: ', NEW.ID_elementos_deportivos), NOW());
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_ELEMENTOS` AFTER DELETE ON `elementos deportivos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se eliminó el elemento deportivo: ', OLD.nombre, ' ID: ', OLD.ID_elementos_deportivos), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `ID_empleados` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `sueldo` int(20) NOT NULL,
  `turno` varchar(20) NOT NULL,
  `cargo` varchar(20) NOT NULL,
  `DNI` int(20) NOT NULL,
  `telefono` int(40) NOT NULL,
  `correo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`ID_empleados`, `nombre`, `apellido`, `fecha_nacimiento`, `sueldo`, `turno`, `cargo`, `DNI`, `telefono`, `correo`) VALUES
(1, 'José Manuel', 'Venteo', '2004-12-10', 300000, 'Mañana', 'Dueño', 92583068, 380463067, 'jose@venteo.com'),
(2, 'Kim', 'Termica', '1994-07-05', 400000, 'Tarde', 'Instructor', 75489375, 587943758, 'kimbesha34@gmail.com'),
(3, 'T. Jenna', 'Swift', '1998-12-13', 130000, 'Noche', 'Gerente', 13131313, 546546234, 'tswift@gmail.com'),
(4, 'Pedro', 'Del Valle', '1990-04-09', 10000, 'Mañana', 'Conserje', 78432346, 380478230, 'pdrito@gmail.com'),
(5, 'Valentino', 'Herrera', '2010-10-10', 100000, 'Mañana, Tarde', 'Instructor', 3920432, 380410101, 'valeh@gmail.com'),
(6, 'Mónica', 'Oviedo', '1973-02-03', 300000, 'Tarde', 'Instructor', 784320923, 380412783, 'oviedomonik@gmail.com'),
(7, 'Roberto', 'Pardo', '1984-11-08', 150000, 'Tarde', 'Instructor', 325363, 325423754, 'rpardo@gmail.com');

--
-- Disparadores `empleados`
--
DELIMITER $$
CREATE TRIGGER `ADD_EVENTO_EMPLEADOS` AFTER INSERT ON `empleados` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se agregó un nuevo Empleado: ', NEW.nombre, ' ', NEW.apellido, ' ID: ', NEW.ID_empleados), NOW());
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_EMPLEADOS` AFTER DELETE ON `empleados` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se eliminó Empleado: ', OLD.nombre, ' ', OLD.apellido, ' ID: ', OLD.ID_empleados), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados_mes_gastos`
--

CREATE TABLE `empleados_mes_gastos` (
  `FK_empleados` int(11) NOT NULL,
  `FK_mes` int(11) NOT NULL,
  `FK_gastos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `empleados_mes_gastos`
--

INSERT INTO `empleados_mes_gastos` (`FK_empleados`, `FK_mes`, `FK_gastos`) VALUES
(2, 1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `eventos`
--

CREATE TABLE `eventos` (
  `id` int(11) NOT NULL,
  `accion` varchar(255) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `eventos`
--

INSERT INTO `eventos` (`id`, `accion`, `fecha`) VALUES
(1, 'Se dio de baja el Miembro: Viktoria Arancio del curso: Yoga', '2024-10-11 21:28:00'),
(2, 'Se inscribió Viktoria Arancio al curso Yoga', '2024-10-11 21:28:09'),
(3, 'Se dio de baja el Miembro: Viktoria Arancio del curso: Yoga', '2024-10-11 21:29:09'),
(4, 'Se inscribió Viktoria Arancio al curso Pilates', '2024-10-11 21:29:09'),
(5, 'Se dio de baja el Miembro: Viktoria Arancio del curso: Pilates', '2024-10-11 21:30:11'),
(6, 'Se inscribió Viktoria Arancio al curso Pilates', '2024-10-11 21:30:32'),
(7, 'Nuevo Ingreso, ID: 6', '2024-10-11 21:32:17'),
(8, 'Nuevo Ingreso, ID: 7', '2024-10-11 21:32:44');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gastos`
--

CREATE TABLE `gastos` (
  `ID_gastos` int(11) NOT NULL,
  `fecha_gasto` date NOT NULL,
  `monto` int(50) NOT NULL,
  `forma_pago` varchar(20) NOT NULL,
  `concepto` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `gastos`
--

INSERT INTO `gastos` (`ID_gastos`, `fecha_gasto`, `monto`, `forma_pago`, `concepto`) VALUES
(1, '2024-07-22', 840000, 'transferencia', 'caminadora'),
(2, '2024-07-22', 400000, 'transferencia', 'sueldo');

--
-- Disparadores `gastos`
--
DELIMITER $$
CREATE TRIGGER `ADD_EVENTO_GASTOS` AFTER INSERT ON `gastos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Nuevo Gasto, ID: ', NEW.ID_gastos), NOW());
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_GASTOS` AFTER DELETE ON `gastos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Gasto Eliminado, ID: ', OLD.ID_gastos), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingresos`
--

CREATE TABLE `ingresos` (
  `ID_ingresos` int(11) NOT NULL,
  `fecha_pago` date NOT NULL,
  `forma_pago` varchar(20) NOT NULL,
  `monto` int(50) NOT NULL,
  `concepto` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `ingresos`
--

INSERT INTO `ingresos` (`ID_ingresos`, `fecha_pago`, `forma_pago`, `monto`, `concepto`) VALUES
(1, '2024-06-24', 'efectivo', 0, 'membresia'),
(2, '2024-08-08', 'efectivo', 10000, 'cursos'),
(3, '2024-08-12', 'transferencia', 35000, 'membresía, curso'),
(4, '2024-08-27', 'Transferencia', 33333, 'tu mama'),
(5, '2024-08-27', 'Transferencia', 1111, 'k'),
(6, '2024-10-11', 'Transferencia', 60000, 'Cuota de Miembro44002362 por 4 mes/es'),
(7, '2024-10-11', 'Tarjeta', 200000, 'Cuota de Miembro44984514 por 10 mes/es');

--
-- Disparadores `ingresos`
--
DELIMITER $$
CREATE TRIGGER `ADD_EVENTO_INGRESOS` AFTER INSERT ON `ingresos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Nuevo Ingreso, ID: ', NEW.ID_ingresos), NOW());
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_INGRESOS` AFTER DELETE ON `ingresos` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Ingreso Eliminado, ID: ', OLD.ID_ingresos), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `ID_login` int(11) NOT NULL,
  `FK_empleado` int(11) DEFAULT NULL,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `nivel_acceso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`ID_login`, `FK_empleado`, `usuario`, `contraseña`, `nivel_acceso`) VALUES
(1, 1, 'venteveo', '123', 3),
(2, 2, 'kimk', '123', 1),
(3, 3, 'tswift', '123', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mes`
--

CREATE TABLE `mes` (
  `ID_mes` int(11) NOT NULL,
  `mes` varchar(11) NOT NULL,
  `FK_año` int(11) NOT NULL,
  `numero_mes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `mes`
--

INSERT INTO `mes` (`ID_mes`, `mes`, `FK_año`, `numero_mes`) VALUES
(1, 'julio', 1, 7),
(2, 'agosto', 1, 8),
(3, 'Septiembre', 1, 9),
(4, 'Octubre', 1, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `miembros`
--

CREATE TABLE `miembros` (
  `ID_miembro` int(10) NOT NULL,
  `DNI` int(10) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `edad` int(5) NOT NULL,
  `fecha_inscripcion` date NOT NULL,
  `duracion_membresia` int(5) NOT NULL,
  `costo_total` int(20) NOT NULL,
  `deudor` tinyint(1) NOT NULL,
  `telefono` int(40) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `puntos` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `miembros`
--

INSERT INTO `miembros` (`ID_miembro`, `DNI`, `nombre`, `apellido`, `edad`, `fecha_inscripcion`, `duracion_membresia`, `costo_total`, `deudor`, `telefono`, `correo`, `puntos`) VALUES
(1, 45254686, 'Viktoria', 'Arancio', 20, '2024-06-24', 3, 0, 0, 380417074, 'aranciomarivi@gmail.com', 0),
(3, 44984514, 'Matias', 'Moreno', 22, '2024-06-24', 15, 20000, 0, 380489234, 'matifmoreno@gmail.com', 500),
(4, 44002362, 'Francisco', 'Brizuela', 42, '2024-08-01', 5, 15000, 1, 3476247, 'franbri@gmail.com', 0),
(5, 5462452, 'Tatiana', 'Gómez', 17, '2024-07-01', 3, 17000, 0, 654132473, '', 0),
(6, 9878623, 'Lucas', 'Rearte', 32, '2024-04-01', 5, 16500, 0, 35245436, '', 0),
(7, 5435234, 'Luis Manuel', 'Guerra', 27, '2024-07-16', 5, 15000, 0, 34762477, 'luisitoguerra@gmail.com', 235);

--
-- Disparadores `miembros`
--
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_MIEMBROS` AFTER DELETE ON `miembros` FOR EACH ROW BEGIN
    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se eliminó Miembro: ', OLD.nombre, ' ', OLD.apellido, ' ID: ', OLD.ID_miembro), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `miembros_cursos`
--

CREATE TABLE `miembros_cursos` (
  `FK_miembros` int(11) NOT NULL,
  `FK_cursos` int(11) NOT NULL,
  `ID_inscripción` int(11) NOT NULL,
  `fecha_inscripcion` date DEFAULT NULL,
  `meses` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `miembros_cursos`
--

INSERT INTO `miembros_cursos` (`FK_miembros`, `FK_cursos`, `ID_inscripción`, `fecha_inscripcion`, `meses`) VALUES
(3, 5, 6, '2024-07-04', 11),
(3, 6, 7, '2024-07-01', 10),
(3, 7, 8, '2024-07-01', 5),
(5, 3, 9, '2024-08-08', 2),
(6, 4, 10, '2024-08-08', 5),
(7, 2, 11, '2024-08-11', 7),
(4, 1, 18, '2024-08-12', 5),
(4, 4, 43, '2024-08-19', 1),
(4, 5, 44, '2024-08-19', 4),
(4, 6, 45, '2024-08-19', 6),
(5, 2, 46, '2024-08-19', 3),
(5, 4, 47, '2024-08-19', 5),
(5, 6, 48, '2024-08-19', 7),
(3, 1, 49, '2024-08-19', 6),
(3, 2, 63, '2024-08-20', 3),
(3, 4, 64, '2024-08-20', 5),
(6, 2, 68, '2024-08-20', 3),
(6, 5, 69, '2024-08-20', 5),
(4, 2, 85, '2024-08-20', 5),
(4, 3, 86, '2024-08-20', 2),
(4, 7, 87, '2024-08-20', 8),
(5, 1, 88, '2024-08-20', 3),
(1, 5, 114, '2024-08-27', 1),
(1, 6, 115, '2024-08-27', 1),
(1, 1, 122, '2024-10-11', 1);

--
-- Disparadores `miembros_cursos`
--
DELIMITER $$
CREATE TRIGGER `ADD_EVENTO_MIEMBROS_CURSOS` AFTER INSERT ON `miembros_cursos` FOR EACH ROW BEGIN
    DECLARE miembro_nombre VARCHAR(255);
    DECLARE curso_nombre VARCHAR(255);

    SELECT CONCAT(miembros.nombre, ' ', miembros.apellido) INTO miembro_nombre
    FROM miembros
    WHERE ID_miembro = NEW.FK_miembros;

    SELECT cursos.nombre INTO curso_nombre
    FROM cursos
    WHERE ID_cursos = NEW.FK_cursos;

    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se inscribió ', miembro_nombre, ' al curso ', curso_nombre), NOW());
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `DEL_EVENTO_MIEMBROS_CURSOS` AFTER DELETE ON `miembros_cursos` FOR EACH ROW BEGIN
    DECLARE miembro_nombre VARCHAR(255);
    DECLARE curso_nombre VARCHAR(255);

    SELECT CONCAT(miembros.nombre, ' ', miembros.apellido) INTO miembro_nombre
    FROM miembros
    WHERE ID_miembro = OLD.FK_miembros;

    SELECT cursos.nombre INTO curso_nombre
    FROM cursos
    WHERE ID_cursos = OLD.FK_cursos;

    INSERT INTO eventos(accion, fecha)
    VALUES(CONCAT('Se dio de baja el Miembro: ', miembro_nombre, ' del curso: ', curso_nombre), NOW());
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `miembros_mes_ingresos`
--

CREATE TABLE `miembros_mes_ingresos` (
  `FK_miembros` int(11) NOT NULL,
  `FK_mes` int(11) NOT NULL,
  `FK_ingresos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `miembros_mes_ingresos`
--

INSERT INTO `miembros_mes_ingresos` (`FK_miembros`, `FK_mes`, `FK_ingresos`) VALUES
(1, 1, 1),
(1, 2, 2),
(3, 4, 7),
(4, 4, 6),
(5, 2, 3);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `año`
--
ALTER TABLE `año`
  ADD PRIMARY KEY (`ID_año`);

--
-- Indices de la tabla `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`ID_cursos`),
  ADD KEY `FK_instructor` (`FK_empleados`);

--
-- Indices de la tabla `cursos_elementos_maquinas`
--
ALTER TABLE `cursos_elementos_maquinas`
  ADD KEY `FK_cursos` (`FK_cursos`),
  ADD KEY `FK_elementos` (`FK_elementos`);

--
-- Indices de la tabla `cursos_mes_ingresos`
--
ALTER TABLE `cursos_mes_ingresos`
  ADD PRIMARY KEY (`FK_cursos`,`FK_mes`,`FK_ingresos`),
  ADD KEY `FK_mes` (`FK_mes`),
  ADD KEY `FK_ingresos` (`FK_ingresos`);

--
-- Indices de la tabla `elementos deportivos`
--
ALTER TABLE `elementos deportivos`
  ADD PRIMARY KEY (`ID_elementos_deportivos`),
  ADD KEY `FK_precio_gasto` (`precio`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`ID_empleados`);

--
-- Indices de la tabla `empleados_mes_gastos`
--
ALTER TABLE `empleados_mes_gastos`
  ADD KEY `FK_empleados` (`FK_empleados`),
  ADD KEY `FK_gastos` (`FK_gastos`),
  ADD KEY `FK_mes` (`FK_mes`);

--
-- Indices de la tabla `eventos`
--
ALTER TABLE `eventos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `gastos`
--
ALTER TABLE `gastos`
  ADD PRIMARY KEY (`ID_gastos`);

--
-- Indices de la tabla `ingresos`
--
ALTER TABLE `ingresos`
  ADD PRIMARY KEY (`ID_ingresos`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`ID_login`),
  ADD KEY `FK_empleado` (`FK_empleado`);

--
-- Indices de la tabla `mes`
--
ALTER TABLE `mes`
  ADD PRIMARY KEY (`ID_mes`),
  ADD KEY `FK_año` (`FK_año`);

--
-- Indices de la tabla `miembros`
--
ALTER TABLE `miembros`
  ADD PRIMARY KEY (`ID_miembro`);

--
-- Indices de la tabla `miembros_cursos`
--
ALTER TABLE `miembros_cursos`
  ADD PRIMARY KEY (`ID_inscripción`),
  ADD KEY `FK_miembros` (`FK_miembros`),
  ADD KEY `FK_cursos` (`FK_cursos`);

--
-- Indices de la tabla `miembros_mes_ingresos`
--
ALTER TABLE `miembros_mes_ingresos`
  ADD PRIMARY KEY (`FK_miembros`,`FK_mes`,`FK_ingresos`),
  ADD KEY `FK_mes` (`FK_mes`),
  ADD KEY `FK_ingresos` (`FK_ingresos`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `año`
--
ALTER TABLE `año`
  MODIFY `ID_año` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `cursos`
--
ALTER TABLE `cursos`
  MODIFY `ID_cursos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `elementos deportivos`
--
ALTER TABLE `elementos deportivos`
  MODIFY `ID_elementos_deportivos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `ID_empleados` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `eventos`
--
ALTER TABLE `eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `gastos`
--
ALTER TABLE `gastos`
  MODIFY `ID_gastos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `ingresos`
--
ALTER TABLE `ingresos`
  MODIFY `ID_ingresos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `ID_login` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `mes`
--
ALTER TABLE `mes`
  MODIFY `ID_mes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `miembros`
--
ALTER TABLE `miembros`
  MODIFY `ID_miembro` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `miembros_cursos`
--
ALTER TABLE `miembros_cursos`
  MODIFY `ID_inscripción` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cursos`
--
ALTER TABLE `cursos`
  ADD CONSTRAINT `FK_instructor` FOREIGN KEY (`FK_empleados`) REFERENCES `empleados` (`ID_empleados`);

--
-- Filtros para la tabla `cursos_elementos_maquinas`
--
ALTER TABLE `cursos_elementos_maquinas`
  ADD CONSTRAINT `FK_cursos` FOREIGN KEY (`FK_cursos`) REFERENCES `cursos` (`ID_cursos`),
  ADD CONSTRAINT `FK_elementos` FOREIGN KEY (`FK_elementos`) REFERENCES `elementos deportivos` (`ID_elementos_deportivos`);

--
-- Filtros para la tabla `cursos_mes_ingresos`
--
ALTER TABLE `cursos_mes_ingresos`
  ADD CONSTRAINT `cursos_mes_ingresos_ibfk_1` FOREIGN KEY (`FK_cursos`) REFERENCES `cursos` (`ID_cursos`),
  ADD CONSTRAINT `cursos_mes_ingresos_ibfk_2` FOREIGN KEY (`FK_mes`) REFERENCES `mes` (`ID_mes`),
  ADD CONSTRAINT `cursos_mes_ingresos_ibfk_3` FOREIGN KEY (`FK_ingresos`) REFERENCES `ingresos` (`ID_ingresos`);

--
-- Filtros para la tabla `empleados_mes_gastos`
--
ALTER TABLE `empleados_mes_gastos`
  ADD CONSTRAINT `FK_empleados` FOREIGN KEY (`FK_empleados`) REFERENCES `empleados` (`ID_empleados`),
  ADD CONSTRAINT `FK_gastos` FOREIGN KEY (`FK_gastos`) REFERENCES `gastos` (`ID_gastos`),
  ADD CONSTRAINT `FK_mes` FOREIGN KEY (`FK_mes`) REFERENCES `mes` (`ID_mes`);

--
-- Filtros para la tabla `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`FK_empleado`) REFERENCES `empleados` (`ID_empleados`);

--
-- Filtros para la tabla `mes`
--
ALTER TABLE `mes`
  ADD CONSTRAINT `FK_año` FOREIGN KEY (`FK_año`) REFERENCES `año` (`ID_año`);

--
-- Filtros para la tabla `miembros_cursos`
--
ALTER TABLE `miembros_cursos`
  ADD CONSTRAINT `FK_miembros` FOREIGN KEY (`FK_miembros`) REFERENCES `miembros` (`ID_miembro`),
  ADD CONSTRAINT `miembros_cursos_ibfk_1` FOREIGN KEY (`FK_cursos`) REFERENCES `cursos` (`ID_cursos`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `miembros_mes_ingresos`
--
ALTER TABLE `miembros_mes_ingresos`
  ADD CONSTRAINT `miembros_mes_ingresos_ibfk_1` FOREIGN KEY (`FK_miembros`) REFERENCES `miembros` (`ID_miembro`),
  ADD CONSTRAINT `miembros_mes_ingresos_ibfk_2` FOREIGN KEY (`FK_mes`) REFERENCES `mes` (`ID_mes`),
  ADD CONSTRAINT `miembros_mes_ingresos_ibfk_3` FOREIGN KEY (`FK_ingresos`) REFERENCES `ingresos` (`ID_ingresos`);

DELIMITER $$
--
-- Eventos
--
CREATE DEFINER=`root`@`localhost` EVENT `reducir_meses_por_inscripcion` ON SCHEDULE EVERY 1 DAY STARTS '2024-08-19 04:11:13' ON COMPLETION NOT PRESERVE ENABLE DO UPDATE miembros_cursos
    SET Meses = Meses - 1
    WHERE Meses > 0 
    AND CURDATE() >= DATE_ADD(Fecha_Inscripcion, INTERVAL 1 MONTH)$$

DELIMITER ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
