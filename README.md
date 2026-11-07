# 📚 Sistema de Gestión de Biblioteca (ACABiblioteca)

Aplicación de escritorio desarrollada en C# utilizando Windows Forms y Microsoft SQL Server, diseñada para administrar de manera integral los procesos bibliográficos de una institución educativa. 

Este proyecto implementa los principios de la **Programación Orientada a Objetos (POO)**, arquitectura por capas, operaciones CRUD seguras mediante consultas parametrizadas y control automático de inventario en tiempo real.

---

## ✨ Características Principales

* **🖥️ Interfaz Unificada y Navegación Centralizada:** Menú lateral intuitivo con un módulo de bienvenida (`FrmInicio`) y diseño visual consistente en todos los formularios.
* **📖 Gestión de Libros:** Registro, consulta, edición, eliminación y filtrado de obras bibliográficas, vinculadas directamente con sus autores y editoriales.
* **✍️ Gestión de Autores y Editoriales:** Administración de catálogos y sellos editoriales con validaciones de integridad referencial.
* **👥 Gestión de Usuarios:** Control de miembros de la biblioteca con restricción de documentos duplicados.
* **🔄 Módulo de Préstamos y Devoluciones Inteligente:**
  * Al **guardar un préstamo**, valida existencias disponibles (`Existencias > 0`), descuenta automáticamente una unidad (`-1`) del inventario y asigna el estado `'Prestado'`.
  * Al **registrar una devolución** (mediante el botón de edición), actualiza la fecha de entrega, conmuta el estado a `'Devuelto'` y repone una unidad (`+1`) al stock del libro.
* **📊 Módulo de Reportes:** Consultas consolidadas sobre el estado operativo de la biblioteca.

---

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Framework / .NET Core)
* **Interfaz Gráfica:** Windows Forms (WinForms)
* **Gestor de Base de Datos:** Microsoft SQL Server
* **Conectividad a Datos:** `Microsoft.Data.SqlClient` (ADO.NET)
* **Control de Versiones:** Git y GitHub

---

## 🗄️ Esquema de Base de Datos

La base de datos relacional está compuesta por 5 tablas principales:
1. `Autores` (Información biográfica)
2. `Editoriales` (Casas publicadoras)
3. `Libros` (Catálogo con control de existencias)
4. `Usuarios` (Lectores registrados)
5. `Prestamos` (Registro transaccional de salidas y devoluciones)

---

## 🚀 Guía de Instalación y Ejecución

### 1. Prerrequisitos
* Tener instalado **Visual Studio** (con la carga de trabajo de desarrollo de escritorio de .NET).
* Tener instalado **Microsoft SQL Server** o SQL Server Express.

### 2. Configuración de la Base de Datos
1. Abre tu gestor de base de datos SQL Server Management Studio (SSMS).
2. Crea una nueva base de datos ejecutando el script SQL provisto en el proyecto (`script_base_datos.sql`).
3. Asegúrate de insertar los datos de prueba iniciales para el correcto funcionamiento de los desplegables (`ComboBox`).

### 3. Configuración de la Conexión
1. Clona o descarga este repositorio en tu equipo local.
2. Abre la solución de Visual Studio (`ACABiblioteca.sln`).
3. Dirígete a la clase encargada de la conexión (`Conexion.cs`) y verifica que la cadena de conexión apunte correctamente a tu instancia local de SQL Server.

### 4. Ejecución
1. Haz clic en el botón **Iniciar** (o presiona `F5`) en Visual Studio para compilar y ejecutar la aplicación.

---

## 📂 Estructura del Repositorio

```text
ACABiblioteca/
│
├── CapaDatos/          # Conexión y acceso a SQL Server
├── Formularios/        # Vistas Windows Forms (FrmPrincipal, FrmLibros, FrmPrestamos, etc.)
├── Documentacion/      # Manual técnico en formato Markdown y PDF
├── Database/           # Script SQL de creación e inserción de datos
└── README.md           # Documentación general del proyecto
```

---

## 👨‍💻 Autor

* **Julián Andrés Hernández Alarcón**
* **Curso:** Programación Avanzada (Grupo 54465)
* **Institución:** Institución Universitaria CUN
* **Docente:** Veronica Castro Munar
* **Año:** 2026
