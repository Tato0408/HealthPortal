# HealthPortal — Gestión de Clínicas Escolares de Primeros Auxilios

> Aplicación de escritorio para la gestión de las **clínicas de primeros auxilios de instituciones educativas**: pacientes (alumnos y personal), visitas, inventario de medicamentos, usuarios y reportes, todo desde una sola herramienta.

---

## Contenido

- [Descripción](#descripción)
- [Autores](#autores)
- [Recursos](#recursos)
- [Stack Tecnológico](#stack-tecnológico)
- [Requisitos previos](#requisitos-previos)
- [Arquitectura del Proyecto](#arquitectura-del-proyecto)
- [Librerías principales y su función](#librerías-principales-y-su-función)
- [Convenciones de nomenclatura](#convenciones-de-nomenclatura)
- [Seguridad y manejo de contraseñas](#seguridad-y-manejo-de-contraseñas)
- [Base de datos](#base-de-datos)
- [Configuración del servidor](#configuración-del-servidor)
- [Credenciales de correo](#credenciales-de-correo)
- [Ejecución del Proyecto](#ejecución-del-proyecto)
- [Solución de problemas comunes](#solución-de-problemas-comunes)

---

## Descripción

HealthPortal digitaliza el trabajo diario de la enfermería o clínica de primeros auxilios de un colegio: quién llegó, por qué, qué se le dio y cuánto queda en inventario. Es una aplicación **Windows Forms (C#)** conectada a **SQL Server**, que puede trabajar contra un servidor local o uno remoto (SmarterASP.net).

Al abrirse, el sistema decide qué pantalla mostrar según el estado de la base de datos (`CommonMethods.DetermineInitialForm`):

1. Si no existe el archivo de conexión `config_server.xml`, pide primero la **configuración del servidor**.
2. Si no hay institución registrada, inicia la **configuración inicial** (primera institución).
3. Si hay institución pero no usuarios, pide crear el **primer usuario** (con verificación por correo).
4. En cualquier otro caso, muestra el **inicio de sesión**.

Módulos del sistema:

- **Dashboard** — Pantalla principal con accesos a todos los módulos según el usuario.
- **Pacientes** — Alta, edición y consulta de pacientes, roles de paciente, registro de visitas y pacientes atendidos. Eliminar un paciente requiere confirmar con contraseña o intervención del administrador.
- **Secciones** — Grados, secciones académicas y especialidades de la institución.
- **Inventario** — Medicamentos, categorías y el **índice de uso** de cada insumo.
- **Usuarios** — Gestión de las cuentas que usan el sistema.
- **Reportes** — Reportes generales de usuarios, pacientes, visitas e inventario, y reporte parametrizado de una visita específica (RDLC + ReportViewer).
- **Configuración** — Datos de la institución, del usuario, preguntas de seguridad, servidor de base de datos, preferencias del programa y acceso al manual de usuario.
- **Gestión de contraseñas** — Contraseña segura obligatoria, cambio de contraseña en el primer inicio de sesión y cuatro métodos de recuperación:
  - Intervención de un administrador.
  - Envío de contraseña temporal por correo electrónico.
  - Reinicio por parte del administrador.
  - Preguntas de seguridad.

> **Nota:** este repositorio es de **solo lectura**: el proyecto puede descargarse y ejecutarse, pero no se aceptan modificaciones.

---

## Autores

| # | Autor | GitHub |
|---|-------|--------|
| 1 | Juan Adolfo Portillo Sánchez | [@Juan421P](https://github.com/Juan421P) |
| 2 | Gabriela Isabel Castillo Mena | [@GabrielaMena018](https://github.com/GabrielaMena018) |
| 3 | Freddy Ricardo Pérez Alvarenga | [@Tato0408](https://github.com/Tato0408) |

**Año de creación:** 2024

---

## Recursos

| Recurso | Enlace |
|---------|--------|
| Manual de usuario | [healthportal2024.netlify.app](https://healthportal2024.netlify.app/) |

---

## Stack Tecnológico

| Capa | Tecnologías |
|------|-------------|
| **Aplicación de escritorio** | C#, Windows Forms, .NET Framework 4.7.2 |
| **Base de datos** | SQL Server 2022 (local o remoto en SmarterASP.net), procedimientos almacenados y vistas |
| **Reportes** | Microsoft ReportViewer (WinForms) + archivos `.rdlc` y DataSets tipados (`.xsd`) |
| **Correo** | `System.Net.Mail` (SMTP de Gmail) |

---

## Requisitos previos

| Herramienta | Para qué |
|---|---|
| Windows 10/11 | La aplicación es Windows Forms, solo corre en Windows |
| Visual Studio 2022 con la carga de trabajo **Desarrollo de escritorio de .NET** | Abrir `HealthPortalProject.sln`, compilar y depurar |
| .NET Framework 4.7.2 Developer Pack | Framework de destino del proyecto |
| SQL Server 2022 (o Express) + SQL Server Management Studio | Base de datos local; también puede usarse el servidor remoto |
| Extensión **Microsoft RDLC Report Designer** _(opcional)_ | Solo si vas a editar los reportes `.rdlc` |

---

## Arquitectura del Proyecto

```
HealthPortal/
├── Controller/                         # Lógica de cada pantalla: escucha eventos de la vista y llama a los DAO
│   ├── Dashboard/
│   ├── FirstUsage/                     # Creación de institución, primer usuario y verificación de correo
│   ├── Login/
│   ├── MainPage/
│   ├── PasswordManagement/             # Cambio y métodos de recuperación de contraseña
│   ├── PatientAdministration/          # Pacientes, roles, visitas y eliminación protegida
│   ├── SectionAdministration/
│   ├── InventoryAdministration/        # Medicamentos, categorías e índice de uso
│   ├── UserAdministration/
│   └── Settings/                       # Institución, usuario, servidor, preguntas de seguridad, manuales
│
├── Model/
│   ├── dbContext.cs                    # Abre la SqlConnection (autenticación de Windows o de SQL)
│   ├── DAO/                            # Acceso a datos: consultas y procedimientos almacenados (uno por módulo)
│   └── DTO/                            # Objetos de transferencia (uno por módulo) + DTOdbContext (datos de conexión)
│
├── View/                               # Formularios de Windows Forms (Frm*.cs + .Designer.cs + .resx)
│   ├── (mismos módulos que Controller/)
│   └── Reports/                        # Reportes RDLC y sus DataSets
│       ├── Inventory/                  # General_Inventory.rdlc
│       ├── Patient/                    # General_Patient, General_Visit, specific_Visit
│       └── User/                       # General_Users.rdlc
│
├── Helper/
│   ├── CommonMethods.cs                # Arranque, lectura de config_server.xml, hash, correos, validaciones de TextBox
│   └── CurrentUserData.cs              # Datos del usuario con sesión iniciada
│
├── Database/
│   └── HealthPortal.sql                # Script de creación de la base de datos (SQL Server)
│
├── Resources/                          # Controles personalizados: CustomTextBox, PanelCustom, RJButton
├── Properties/                         # AssemblyInfo, Settings (RememberMeToken), recursos
├── App.config                          # Ajustes generales y binding redirects de ReportViewer (sin credenciales)
├── Secrets.example.config              # Plantilla de credenciales de correo (copiar como Secrets.config)
├── packages.config                     # Paquetes NuGet
├── Program.cs                          # Punto de entrada
└── HealthPortalProject.sln
```

> **Nota:** el proyecto sigue el patrón **MVC**: cada formulario de `View/` tiene un `Controller` homónimo que se suscribe a sus eventos (por ejemplo `FrmLogin` ↔ `ControllerLogin`), y los controladores solo hablan con la base de datos a través de los `DAO` del `Model`, usando los `DTO` para mover los datos.

---

## Librerías principales y su función

| Librería | Uso |
|----------|-----|
| `System.Windows.Forms` | Interfaz gráfica de la aplicación |
| `System.Data.SqlClient` | Conexión y consultas a SQL Server |
| `Microsoft.ReportingServices.ReportViewerControl.Winforms` | Control `ReportViewer` para mostrar e imprimir/exportar los reportes `.rdlc` |
| `Microsoft.ReportViewer.Common` / `Microsoft.ReportViewer.Runtime.Common` | Motor de renderizado de los reportes |
| `Microsoft.SqlServer.Types` | Tipos de SQL Server requeridos por ReportViewer |
| `System.Windows.Forms.DataVisualization` | Gráficos del módulo de inventario (índice de uso de medicamentos) |
| `System.Security.Cryptography` | Hash SHA-256 de contraseñas y generación aleatoria segura de contraseñas temporales |
| `System.Net.Mail` | Envío de códigos de verificación y contraseñas temporales por correo |
| `System.Xml` | Lectura/escritura del archivo de conexión `config_server.xml` |

---

## Convenciones de nomenclatura

| Convención | Dónde se usa |
|---|---|
| `Frm` + `PascalCase` | Formularios de la vista (`FrmLogin`, `FrmAddUpdatePatient`). |
| `Controller` + nombre del formulario | Controlador de cada vista (`ControllerLogin`, `ControllerAddUpdatePatient`). |
| `DAO` / `DTO` + módulo | Acceso a datos y objetos de transferencia por módulo (`DAOPatientAdministration`, `DTOPatientAdministration`). |
| `PascalCase` | Clases, métodos públicos y propiedades. |
| `camelCase` | Variables locales y campos privados. |
| `sp` + `PascalCase` (en español) | Procedimientos almacenados de SQL Server (`spIngresarMedicamento`, `spCambiarContraseña`, `spIndiceUsoInventario`). |
| Esquemas en español | Las tablas se agrupan por esquemas como `[Pacientes]`, `[Inventario]`, `[Visitas]`, `[Secciones]`, `[Instituciones]` y `[Vistas]` (vistas de consulta). |
| Códigos `EC_XXX` | Códigos de error que se muestran al usuario mediante `CommonMethods.HandleError` (ej. `EC_001`: no se pudo conectar al servidor). |

Los nombres del código (clases, métodos) están en inglés, mientras que los objetos de la base de datos y los mensajes al usuario están en español.

---

## Seguridad y manejo de contraseñas

| Mecanismo | Implementación |
|---|---|
| Hash de contraseñas | SHA-256 (`CommonMethods.ComputeSha256Hash`); la contraseña nunca se guarda en texto plano |
| Contraseña segura | Mínimo 8 caracteres, con al menos una mayúscula, una minúscula, un número y un carácter especial (`@ $ # _`) |
| Usuarios nuevos | Reciben por correo una contraseña temporal generada con `RNGCryptoServiceProvider` y deben cambiarla al iniciar sesión por primera vez |
| Primer usuario | Debe confirmar su correo con un código de verificación |
| Archivo de conexión | `config_server.xml` guarda servidor, base de datos, usuario y contraseña de SQL codificados (no en texto plano legible) |
| Campos de texto | `CustomTextBox` bloquea copiar/pegar y caracteres no permitidos según el tipo de campo (`Tag`) |

---

## Base de datos

El repositorio incluye el script completo de la base de datos en [`Database/HealthPortal.sql`](Database/HealthPortal.sql). Se publica **con fines educativos y de referencia**: permite que cualquier persona interesada en el proyecto pueda estudiar su modelo de datos, reproducir el entorno y ejecutar la aplicación de principio a fin sin depender de la infraestructura original.

El script contiene únicamente la **estructura** de la base de datos y los catálogos mínimos que la aplicación necesita para funcionar. **No incluye datos reales** de pacientes, usuarios ni instituciones, ni credenciales de ningún servidor.

| Contenido | Detalle |
|---|---|
| Esquemas | `Secciones`, `Pacientes`, `Inventario`, `Institución`, `Visitas`, `Vistas` y `ProcedimientosAlmacenados` |
| Tablas | 18 tablas con sus llaves primarias, foráneas y restricciones `UNIQUE` |
| Vistas | 16 vistas usadas por los listados, los reportes y los gráficos |
| Procedimientos almacenados | 21 procedimientos para las operaciones transaccionales (medicamentos, usuarios, secciones, contraseñas y preguntas de seguridad) |
| Catálogos iniciales | Tipos de persona, roles, categorías de inventario, de medicamento y de institución |

Para crearla:

1. Abre `Database/HealthPortal.sql` en **SQL Server Management Studio**.
2. Conéctate a la instancia donde quieras crearla con un usuario que tenga permiso para crear bases de datos. Por ejemplo `localhost\SQLEXPRESS`, o **`(localdb)\MSSQLLocalDB`**, que se instala con Visual Studio y no requiere permisos de administrador.
3. Ejecuta el script completo (**F5**). Se crea la base de datos `HealthPortal` con todos sus objetos.

> **Nota:** el script se recuperó a partir de los respaldos del proyecto. Cuatro objetos que la aplicación utiliza no estaban en esos respaldos (`viewInfoPacientes`, `viewPorcentajeEstudiantesPorSeccion`, `spIndiceUsoInventario` y la versión actual de `spActualizarMedicamento`), por lo que se reconstruyeron a partir del código y están identificados con un comentario dentro del script.

---

## Configuración del servidor

La conexión a la base de datos **no se toma de `App.config`**, sino del archivo `config_server.xml`, que vive junto al ejecutable (por ejemplo `bin/Debug/`). Si el archivo no existe, la aplicación abre automáticamente la pantalla **Configuración del servidor**, prueba la conexión y lo genera.

| Campo | Descripción |
|---|---|
| `server` | Nombre o dirección del servidor de SQL Server (ej. `localhost\SQLEXPRESS`) |
| `database` | Nombre de la base de datos |
| `sqlAuth` / `sqlPassword` | Usuario y contraseña de SQL Server. Si se dejan vacíos (`null`), se usa **autenticación de Windows** (`Integrated Security`) |

El archivo puede editarse después desde **Configuración → Servidor**, tanto para un servidor local como para el remoto.

Los reportes (TableAdapters de los DataSets) usan esa misma conexión: al leer `config_server.xml`, `dbContext.ApplyConnectionToReports()` reemplaza en tiempo de ejecución la cadena de conexión de `Properties.Settings`. La cadena que aparece en `App.config` es solo un valor local de referencia para el diseñador de DataSets de Visual Studio.

---

## Credenciales de correo

La cuenta de Gmail que envía los códigos de verificación y las contraseñas temporales **no está en el código**: se lee del archivo `Secrets.config`, que está en `.gitignore`.

```bash
# En la carpeta del proyecto (junto a App.config)
copy Secrets.example.config Secrets.config
```

```xml
<appSettings>
    <add key="SmtpUser" value="tu_correo@gmail.com" />
    <add key="SmtpPassword" value="tu_contraseña_de_aplicacion" />
</appSettings>
```

| Clave | Dónde | Descripción |
|---|---|---|
| `SmtpUser` | `Secrets.config` | Cuenta de Gmail de envío (también es el remitente) |
| `SmtpPassword` | `Secrets.config` | [Contraseña de aplicación](https://myaccount.google.com/apppasswords) de Gmail |
| `SmtpHost` / `SmtpPort` | `App.config` | Servidor SMTP (por defecto `smtp.gmail.com:587`) |

Al compilar, `Secrets.config` se copia automáticamente junto al ejecutable. Si no existe, la aplicación funciona igual, pero no podrá enviar correos.

---

## Ejecución del Proyecto

1. Clona o descarga el repositorio.
2. Crea la base de datos ejecutando `Database/HealthPortal.sql` en SQL Server (ver [Base de datos](#base-de-datos)).
3. Abre `HealthPortalProject.sln` en Visual Studio 2022.
4. Restaura los paquetes NuGet (clic derecho sobre la solución → **Restaurar paquetes NuGet**).
5. Copia `Secrets.example.config` como `Secrets.config` y completa las credenciales de correo (ver [Credenciales de correo](#credenciales-de-correo)).
6. Compila y ejecuta con **F5** (o **Iniciar**).
7. En el primer arranque:
   1. Configura el servidor de base de datos (servidor: `localhost\SQLEXPRESS` o `(localdb)\MSSQLLocalDB`, base de datos: `HealthPortal`, usuario y contraseña vacíos para usar autenticación de Windows).
   2. Registra la institución.
   3. Crea el primer usuario y confirma el código que llega a su correo.
8. Inicia sesión con ese usuario.

---

## Solución de problemas comunes

| Síntoma | Causa | Solución |
|---|---|---|
| `CREATE DATABASE permission denied` al ejecutar el script | El usuario de SQL Server no tiene permiso para crear bases de datos | Ejecuta el script con un usuario administrador (por ejemplo `sa`) o pide que te asignen el rol `dbcreator` |
| Aparece el error `EC_001` al abrir la aplicación | SQL Server no está corriendo, o los datos de `config_server.xml` son incorrectos | Verifica que el servicio de SQL Server esté activo y corrige los datos en **Configuración → Servidor** (o borra `config_server.xml` para volver a configurarlo) |
| Siempre pide la configuración del servidor | El ejecutable no encuentra `config_server.xml` en su carpeta de trabajo | Guarda la configuración desde la aplicación; el archivo se crea junto al `.exe` |
| Al compilar: `This project references NuGet package(s) that are missing on this computer` (o errores en referencias de `Microsoft.ReportViewer.*`) | La carpeta `packages/` no se sube al repositorio, así que en una copia recién descargada los paquetes NuGet todavía no existen | Clic derecho sobre la solución → **Restaurar paquetes NuGet** y vuelve a compilar |
| Los reportes no se ven o no se pueden editar | Falta la extensión de diseño de reportes RDLC en Visual Studio | Instala **Microsoft RDLC Report Designer** desde el Marketplace de Visual Studio |
| No llega el correo con el código o la contraseña temporal | Falta `Secrets.config`, sus credenciales son incorrectas o no hay conexión a internet | Crea `Secrets.config` a partir de `Secrets.example.config` con una contraseña de aplicación válida y vuelve a compilar |

---

Este proyecto es de uso académico. Todos los derechos reservados.
