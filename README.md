# 📚 Sistema de Gestión de Biblioteca (WinForms + C# + SQL Server)

Un sistema de escritorio robusto y profesional para la administración integral de bibliotecas, desarrollado en **C# (.NET 8)** con **WinForms**. Aplica una arquitectura en capas limpia, acceso a datos optimizado mediante **Dapper**, y control con procedimientos almacenados en **SQL Server**.

---

## 🎯 Características Principales

* **Gestión de Catálogos:** CRUD completo para Lectores, Empleados, Libros y Ejemplares.
* **Módulo de Préstamos**
* **Control de Devoluciones por Ejemplar:**
  * Actualización individual del estado de cada libro (`Devuelto`, `Dañado`, `Perdido`).
  * Sincronización automática de disponibilidad del inventario en la base de datos.
* **Módulo de Sanciones y Multas:**
  * Registro de penalizaciones ligadas a préstamos específicos por retraso o deterioro.
  * Control de estados de pago de multas (`Pendiente`, `Pagada`).
* **Seguridad e Integridad:** Restricciones a nivel de base de datos (`CHECK constraints`, claves foráneas).

---

## 🛠️ Tecnologías y Herramientas

* **Lenguaje:** C# (.NET 8)
* **Interfaz de Usuario:** Windows Forms (WinForms)
* **Acceso a Datos:** Dapper (ORM liviano)
* **Base de Datos:** Microsoft SQL Server
* **Lógica de BD:** Procedimientos Almacenados (Stored Procedures)
