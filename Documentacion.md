# Sistema de Gestión de Biblioteca - ACABiblioteca

---

## 1. PORTADA

**Institución Universitaria CUN**  
**Programa:** Ingenieria de Sistemas  
**Asignatura:** Programación Avanzada  

### Proyecto: Sistema de Gestión de Biblioteca (ACABiblioteca)

**Presentado por:**  
Julián Andrés Hernández Alarcón  

**Docente:**  
Veronica Castro Munar  

**Ubicación y Fecha:**  
Amagá, Antioquia, Octubre 2026  

---

## 2. CONTRAPORTADA

**Título del Proyecto:** Sistema de Gestión de Biblioteca (ACABiblioteca)  
**Curso:** Programación Avanzada  
**Grupo:** 54465  
**Estudiante:** Julián Andrés Hernández Alarcón  
**Docente:** Veronica Castro Munar  
**Institución:** CUN  
**Año:** 2026  

Proyecto desarrollado como evidencia final del curso, implementando una aplicación de escritorio robusta con C#, Windows Forms, arquitectura orientada a objetos y persistencia de datos relacional en Microsoft SQL Server.

---

## 3. INTRODUCCIÓN

El desarrollo de software orientado a la automatización de procesos administrativos constituye una herramienta fundamental en el entorno educativo moderno. El presente documento técnico detalla la conceptualización, diseño, implementación y pruebas del **Sistema de Gestión de Biblioteca (ACABiblioteca)**.

La aplicación permite resolver la problemática de control de inventario bibliográfico, registro de lectores, asignación de préstamos y recepción de devoluciones de manera automatizada. Utilizando C# bajo el paradigma de la Programación Orientada a Objetos (POO), formularios estructurados en Windows Forms y una base de datos relacional en SQL Server, el sistema garantiza la consistencia de los datos, la integridad referencial y una experiencia de usuario fluida y estandarizada.

---

## 4. OBJETIVOS

### 4.1 Objetivo General
Desarrollar una aplicación de escritorio integral para la gestión de una biblioteca utilizando C#, Windows Forms y SQL Server, que permita administrar libros, autores, editoriales, usuarios y controlar de forma automatizada los préstamos y devoluciones bajo los principios de la Programación Orientada a Objetos.

### 4.2 Objetivos Específicos
* Aplicar los principios de la Programación Orientada a Objetos (POO) en el diseño de clases y control de formularios.
* Diseñar e implementar una base de datos relacional normalizada en Microsoft SQL Server.
* Programar operaciones CRUD eficientes y seguras mediante consultas parametrizadas.
* Integrar un módulo de control de existencias en tiempo real para préstamos (`-1`) y devoluciones (`+1`).
* Implementar una arquitectura lógica por capas (Presentación, Negocio, Datos, Base de Datos).
* Incorporar validaciones estrictas y manejo de excepciones con bloques `try-catch`.
* Gestionar el control de versiones utilizando Git y GitHub.

---

## 5. TABLA DE CONTENIDO

1. Portada
2. Contraportada
3. Introducción
4. Objetivos
5. Tabla de Contenido
6. Planteamiento del problema
7. Análisis de requerimientos
8. Casos de uso
9. Diagrama de clases
10. Modelo entidad-relación
11. Diccionario de datos
12. Arquitectura del sistema
13. Explicación de los módulos desarrollados
14. Descripción de la conexión con SQL Server
15. Capturas de pantalla del sistema
16. Pruebas de funcionamiento
17. Conclusiones
18. Recomendaciones
19. Referencias bibliográficas

---

## 6. PLANTEAMIENTO DEL PROBLEMA

La biblioteca de la institución educativa operaba bajo métodos manuales y registros físicos descentralizados para el control de sus libros, autores y usuarios. Esta metodología presentaba deficiencias críticas:
* **Pérdida de trazabilidad:** Dificultad para conocer en tiempo real qué usuarios mantenían libros en su poder y las fechas límite de entrega.
* **Inconsistencias de inventario:** Préstamos autorizados de libros con existencias agotadas debido a la falta de validación numérica automática.
* **Errores humanos:** Duplicidad en registros de usuarios o libros debido a la ausencia de restricciones de unicidad.

Para dar solución a esta problemática, se diseñó e implementó **ACABiblioteca**, una solución digital centralizada que automatiza los flujos de trabajo bibliotecarios.

---

## 7. ANÁLISIS DE REQUERIMIENTOS

### 7.1 Requerimientos Funcionales
* **RF01 - Gestión de Libros:** Registrar, consultar, editar, eliminar y buscar libros por ISBN o título, vinculándolos a su respectivo autor y editorial.
* **RF02 - Gestión de Autores:** Administrar el registro biográfico de los autores.
* **RF03 - Gestión de Editoriales:** Registrar y administrar las editoriales asociadas al catálogo.
* **RF04 - Gestión de Usuarios:** Registrar lectores con validación de documentos únicos.
* **RF05 - Gestión de Préstamos:** Asociar un usuario con un libro disponible, registrando fechas y descontando existencias en inventario (`-1`).
* **RF06 - Gestión de Devoluciones:** Actualizar el estado del préstamo a `'Devuelto'` y reponer la existencia al libro (`+1`).
* **RF07 - Consultas y Reportes:** Visualizar información consolidada del estado de la biblioteca.
* **RF08 - Navegación Centralizada:** Formulario principal con menú lateral y pantalla de bienvenida.

### 7.2 Requerimientos No Funcionales
* **RNF01:** Interfaz gráfica intuitiva, limpia y unificada en todos los formularios.
* **RNF02:** Uso estricto de consultas parametrizadas para prevenir inyecciones SQL.
* **RNF03:** Manejo centralizado de excepciones con mensajes descriptivos al usuario.
  
<img width="1536" height="1024" alt="image" src="https://github.com/user-attachments/assets/f3504b3f-df9d-4dee-b7b2-191c284c190a" />

---

## 8. CASOS DE USO

* **CU01 - Registrar Préstamo:** El bibliotecario selecciona el usuario y el libro; el sistema comprueba que existan ejemplares disponibles (`Existencias > 0`), guarda el registro con estado `'Prestado'` y descuenta una unidad al stock del libro.
* **CU02 - Registrar Devolución:** El bibliotecario selecciona el préstamo activo de la grilla y hace clic en el botón de edición; el sistema actualiza la fecha de devolución, cambia el estado a `'Devuelto'` y repone una unidad al stock del libro (`+1`).

<img width="1536" height="1024" alt="image" src="https://github.com/user-attachments/assets/49090c8f-f49a-4e5b-a8fb-ce67cd90e708" />

---

## 9. DIAGRAMA DE CLASES

El sistema se estructura mediante clases orientadas a objetos que representan tanto la interfaz gráfica (formularios hijos derivados de la clase `Form`) como la conectividad a bases de datos (`Conexion.cs`), empleando colecciones en memoria como `DataTable` y adaptadores de datos (`SqlDataAdapter`).

<img width="1536" height="1024" alt="image" src="https://github.com/user-attachments/assets/08657040-03b3-4f45-8370-674c96ba9d15" />

---

## 10. MODELO ENTIDAD-RELACIÓN

El esquema relacional consta de 5 entidades principales:
1. `Autores` (1 a N con `Libros`)
2. `Editoriales` (1 a N con `Libros`)
3. `Libros` (1 a N con `Prestamos`)
4. `Usuarios` (1 a N con `Prestamos`)
5. `Prestamos` (Tabla transaccional central)

---

## 11. DICCIONARIO DE DATOS

* **Autores:** `IdAutor` (PK, INT IDENTITY), `Nombre` (VARCHAR), `Apellido` (VARCHAR).
* **Editoriales:** `IdEditorial` (PK, INT IDENTITY), `Nombre` (VARCHAR, UQ).
* **Libros:** `ISBN` (PK, VARCHAR), `Titulo` (VARCHAR), `IdAutor` (FK), `IdEditorial` (FK), `Categoria` (VARCHAR), `Anio` (INT), `Existencias` (INT).
* **Usuarios:** `IdUsuario` (PK, INT IDENTITY), `Nombre` (VARCHAR), `Apellido` (VARCHAR), `Documento` (VARCHAR, UQ), `Telefono` (VARCHAR), `Correo` (VARCHAR).
* **Prestamos:** `IdPrestamo` (PK, INT IDENTITY), `IdUsuario` (FK), `ISBN` (FK), `FechaPrestamo` (DATETIME), `FechaDevolucion` (DATETIME), `Estado` (VARCHAR).

<img width="1536" height="1024" alt="image" src="https://github.com/user-attachments/assets/1abdcde3-6d14-4f02-99aa-31b78a1047ce" />

---

## 12. ARQUITECTURA DEL SISTEMA

Se adopta una arquitectura lógica de capas para separar responsabilidades:
* **Capa de Presentación:** Formularios Windows Forms encargados de la interacción visual y validación inicial de campos.
* **Capa de Lógica de Negocio:** Validación de reglas operativas (existencias de inventario, estados de préstamos).
* **Capa de Acceso a Datos:** Clase utilitaria `Conexion.cs` que encapsula la apertura y cierre de conexiones SQL.
* **Capa de Base de Datos:** Motor relacional Microsoft SQL Server.

<img width="1536" height="1024" alt="image" src="https://github.com/user-attachments/assets/9dd1289c-b24f-43be-9d86-33a0969a538d" />

---

## 13. EXPLICACIÓN DE LOS MÓDULOS DESARROLLADOS

* **Módulo Inicio (`FrmInicio`):** Pantalla centralizada de bienvenida que orienta al operador sobre el uso del sistema.
* **Módulos CRUD (Libros, Autores, Editoriales, Usuarios):** Formularios equipados con botonera estándar (Nuevo, Guardar, Editar, Eliminar, Cancelar) y grillas de visualización en tiempo real.
* **Módulo Préstamos (`FrmPrestamos`):** Administra la lógica transaccional de entrega y devolución de material con actualización automática de stock.

---

## 14. DESCRIPCIÓN DE LA CONEXIÓN CON SQL SERVER

La conexión se gestiona mediante la librería oficial `Microsoft.Data.SqlClient`. La clase `Conexion.cs` centraliza la cadena de conexión al servidor local o instancia configurada, proveyendo métodos seguros para instanciar objetos `SqlConnection` bajo bloques `using`, garantizando la liberación de recursos y el uso de comandos parametrizados.

---

## 15. CAPTURAS DE PANTALLA DEL SISTEMA

<img width="1362" height="760" alt="image" src="https://github.com/user-attachments/assets/c1e9a1df-6e1d-4625-884e-11dae302d9be" />
<img width="1362" height="761" alt="image" src="https://github.com/user-attachments/assets/07553082-2eaa-43ec-8b93-c3c113949b3d" />
<img width="1361" height="764" alt="image" src="https://github.com/user-attachments/assets/00d6bf7a-67a5-442c-8869-6f57d9062bef" />
<img width="1355" height="765" alt="image" src="https://github.com/user-attachments/assets/ac3ff156-afa6-4067-8110-54767e4f7108" />
<img width="1359" height="763" alt="image" src="https://github.com/user-attachments/assets/bb35d087-07fb-48eb-9107-b7ffb0ec6943" />
<img width="1363" height="767" alt="image" src="https://github.com/user-attachments/assets/8ba831d4-3034-4b22-b31e-ff8f6197984e" />
<img width="1358" height="708" alt="image" src="https://github.com/user-attachments/assets/1a3f95a5-5c1a-4ca1-b930-48eeeb6974e1" />

---

## 16. PRUEBAS DE FUNCIONAMIENTO

* Pruebas de consulta de libros:
  
<img width="1044" height="594" alt="image" src="https://github.com/user-attachments/assets/a060b569-f052-4c5d-acc8-00ca743a5e1f" />

* Consulta y edición de Autores

<img width="1055" height="620" alt="image" src="https://github.com/user-attachments/assets/d538af27-f9d7-4402-9382-22dacad10a1a" />

* Guardar nuevos editoriales

<img width="1061" height="597" alt="image" src="https://github.com/user-attachments/assets/d7aa8e61-005c-4056-acb3-5636e7fc6769" />

* Registro de prestamos

<img width="977" height="581" alt="image" src="https://github.com/user-attachments/assets/0a9ba3da-532e-4f85-b18f-64a4d3383b67" />

* Eliminar usuarios

<img width="1042" height="614" alt="image" src="https://github.com/user-attachments/assets/64cd1689-1063-4cd9-9abe-2f09647a17c4" />

* Generar reportes

 <img width="1079" height="527" alt="image" src="https://github.com/user-attachments/assets/bfcba312-4668-4d50-9d0c-64b97e084d0f" />

---

## 17. CONCLUSIONES

* El desarrollo del proyecto permitió consolidar los conceptos fundamentales de la Programación Orientada a Objetos y la construcción de interfaces de escritorio funcionales con Windows Forms.
* La integración de un sistema de control de inventario vinculado directamente a los movimientos de préstamos garantiza la confiabilidad y la integridad operativa de la base de datos relacional.

---

## 18. RECOMENDACIONES

* Implementar un sistema de autenticación por credenciales y roles para diferenciar entre perfiles de operadores y administradores generales.
* Añadir mecanismos de exportación de reportes a formatos digitales portables como PDF.

---

## 19. REFERENCIAS BIBLIOGRÁFICAS

* Microsoft. (2026). *Guía de referencia de Windows Forms y ADO.NET*. Microsoft Learn.
* CUN. (2026). *Fundamentos y Guía Práctica de Programación Avanzada*. Institución Universitaria CUN.
