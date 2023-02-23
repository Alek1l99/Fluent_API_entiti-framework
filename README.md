# Fluent API con Entity Framework
Este repositorio contiene un ejemplo práctico de cómo utilizar Fluent API con Entity Framework para crear un CRUD sencillo de tareas, del curso Curso de Fundamentos de Entity Framework de Platzi

La base de datos utilizada es SQLServer y se ha utilizado tanto migraciones como Data Annotations.

Además, es importante destacar que esta aplicación fue creada utilizando el motor de base de datos SQLServer y que se utilizó el enfoque de Code First, haciendo uso de las migraciones y Data Annotations para definir las relaciones y restricciones de la base de datos.

También se incluye la clase TareasContext que hereda de DbContext y contiene las propiedades DbSet para Categorias y Tareas, además del método OnModelCreating donde se configura la relación entre las entidades y se agregan datos iniciales mediante el uso de Listas.

# En el proyecto se utiliza:
Para utilizar esta API, asegúrate de tener instalados los siguientes paquetes en tu proyecto:

**Microsoft.EntityFrameworkCore** v7.0.3

**Microsoft.EntityFrameworkCore.Design** v7.0.3

**Microsoft.EntityFrameworkCore.InMemory** v7.0.2

**Microsoft.EntityFrameworkCore.SqlServer** v7.0.2

# Conexion a la base de datos
Recuerda que al utilizar esta API, debes configurar tu propia conexión a la base de datos en el archivo **`appsettings.json`**.

La conexión a la base de datos está ubicada en el archivo **`appsettings.json`** bajo el nombre **`CnTareas`**, el cual contiene los tokens de acceso a la base de datos.

Para utilizar esta conexión en el **`Program.cs`** se realiza a través del **`builder`**.
