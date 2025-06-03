# GymApp – Sistema de Control de Reservas para Gimnasio

Aplicación de escritorio desarrollada en **C# con Windows Forms** y **SQL Server** para la gestión de un gimnasio, incluyendo módulos para usuarios, entrenadores, clases, reservas, accesos y reportes. Esta aplicación implementa una arquitectura en capas, patrones de diseño y principios SOLID para garantizar calidad, escalabilidad y mantenimiento eficiente.

---

## Características del Sistema

- Autenticación y control de acceso por roles (Administrador, Miembro).
- Gestión de Miembros y Entrenadores (CRUD).
- Gestión de Clases (capacidad, horario, duración, entrenador).
- Sistema de Reservas con control de disponibilidad y cancelación.
- Registro de accesos y control de asistencia.
- Generación de reportes por clase, miembro y periodo.
- Notificaciones de reservas activas con 24h de anticipación.
- Validaciones de datos y manejo de errores con `try-catch`.
- Diseño limpio, por capas y orientado a buenas prácticas.

---

## Tecnologías Utilizadas

- **Lenguaje:** C#
- **Interfaz:** Windows Forms (.NET Framework)
- **Base de Datos:** SQL Server
- **Acceso a Datos:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataReader`)
- **Patrones de Diseño:** Repository, Unit of Work, Singleton, Factory
- **Estilo de Código:** Principios SOLID, validaciones, manejo de excepciones

---

## Arquitectura del Sistema
GymSystem/
├── Presentacion/ # Capa de presentación (Windows Forms)
├── Entidades/ # Entidades, interfaces, servicios
├── AccesoDatos/ # Acceso a datos, repositorios y UnitOfWork
├── Factories/ # Generación de reportes
├── Negocio/ # Acceso a service
└── README.md # Este archivo

---

## Roles del Sistema

### Administrador
- Gestiona usuarios, entrenadores y clases.
- Control total sobre reservas y reportes.
- Activa/inactiva miembros.

### Miembro
- Reserva y cancela clases (según disponibilidad).
- Consulta historial y recibe recordatorios.
