using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Datos.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "banco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    codigo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FechaCreacionUTC = table.Column<DateTime>(nullable: false),
                    FechaModificacionUTC = table.Column<DateTime>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "provincias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provincias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    codigo = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    codigo = table.Column<string>(type: "varchar(50)", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipocuenta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    codigo = table.Column<string>(type: "varchar(20)", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoempresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    codigo = table.Column<string>(type: "varchar(20)", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    precio = table.Column<float>(type: "float", nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_producto_categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "producto_categoriafk",
                        column: x => x.idCategoria,
                        principalTable: "categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    id_provincia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.id);
                    table.ForeignKey(
                        name: "FK_ciudad_provincia",
                        column: x => x.id_provincia,
                        principalTable: "provincias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    Codigo = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    IdTipoServicio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "servicio_tipo_servicio_fk",
                        column: x => x.IdTipoServicio,
                        principalTable: "tipo_servicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cuenta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FechaCreacionUTC = table.Column<DateTime>(nullable: false),
                    FechaModificacionUTC = table.Column<DateTime>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    numcuenta = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    idBanco = table.Column<int>(type: "int", nullable: false),
                    idTipocuenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "banco_cuentafk",
                        column: x => x.idBanco,
                        principalTable: "banco",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "tipocuenta_cuentafk",
                        column: x => x.idTipocuenta,
                        principalTable: "tipocuenta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    idTipoEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "tipoempresa_empresafk",
                        column: x => x.idTipoEmpresa,
                        principalTable: "tipoempresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductoId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Ubicacion = table.Column<string>(nullable: true),
                    PrecioCompra = table.Column<decimal>(nullable: false),
                    PrecioVenta = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventario_producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "producto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "evento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    fecha_evento = table.Column<DateTime>(type: "datetime", nullable: false),
                    promotor = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    artista = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    IdCiudad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evento", x => x.id);
                    table.ForeignKey(
                        name: "FK_evento_ciudad",
                        column: x => x.IdCiudad,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    idCiudad = table.Column<int>(type: "int", nullable: false),
                    CiudadId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "persona_ciudadfk",
                        column: x => x.idCiudad,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_persona_ciudad_CiudadId1",
                        column: x => x.CiudadId1,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "presupuesto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    version = table.Column<float>(type: "float", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    fecha_evento = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_cotizacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    descuento = table.Column<float>(type: "float", nullable: false),
                    iva = table.Column<float>(type: "float", nullable: false),
                    total = table.Column<float>(type: "float", nullable: false),
                    idevento = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_presupuesto_evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "evento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "presupuesto_eventofk",
                        column: x => x.idevento,
                        principalTable: "evento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    idPersona = table.Column<int>(type: "int", nullable: false),
                    idCiudad = table.Column<int>(type: "int", nullable: false),
                    idCuenta = table.Column<int>(type: "int", nullable: false),
                    idEmpresa = table.Column<int>(type: "int", nullable: false),
                    idFormapago = table.Column<int>(type: "int", nullable: false),
                    limite_credito = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    contacto_correo = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    contacto_telefono = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    fecha_registro = table.Column<DateTime>(type: "datetime", nullable: false),
                    CiudadId1 = table.Column<int>(nullable: true),
                    CuentaId1 = table.Column<int>(nullable: true),
                    EmpresaId1 = table.Column<int>(nullable: true),
                    FormaPagoId1 = table.Column<int>(nullable: true),
                    PersonaId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "cliente_ciudadfk",
                        column: x => x.idCiudad,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_ciudad_CiudadId1",
                        column: x => x.CiudadId1,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "cliente_cuentafk",
                        column: x => x.idCuenta,
                        principalTable: "cuenta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_cuenta_CuentaId1",
                        column: x => x.CuentaId1,
                        principalTable: "cuenta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "cliente_empresafk",
                        column: x => x.idEmpresa,
                        principalTable: "empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_empresa_EmpresaId1",
                        column: x => x.EmpresaId1,
                        principalTable: "empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "cliente_formapagofk",
                        column: x => x.idFormapago,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_FormaPago_FormaPagoId1",
                        column: x => x.FormaPagoId1,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "cliente_personafk",
                        column: x => x.idPersona,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cliente_persona_PersonaId1",
                        column: x => x.PersonaId1,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    idPersona = table.Column<int>(type: "int", nullable: false),
                    empresa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    sueldo = table.Column<float>(type: "float", nullable: false),
                    fecha_contrato = table.Column<DateTime>(type: "datetime", nullable: true),
                    idCiudad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "empleado_ciudadfk",
                        column: x => x.idCiudad,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "empleado_personafk",
                        column: x => x.idPersona,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    idPersona = table.Column<int>(type: "int", nullable: false),
                    empresa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    tiposervicio = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    idCiudad = table.Column<int>(type: "int", nullable: false),
                    idervicio = table.Column<int>(type: "int", nullable: false),
                    idCuenta = table.Column<int>(type: "int", nullable: false),
                    IdFormaPago = table.Column<int>(nullable: false),
                    idempresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "proveedor_ciudadfk",
                        column: x => x.idCiudad,
                        principalTable: "ciudad",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "proveedor_cuentafk",
                        column: x => x.idCuenta,
                        principalTable: "cuenta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "proveedor_empresafk",
                        column: x => x.idempresa,
                        principalTable: "empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "proveedor_IdFormaPagofk",
                        column: x => x.IdFormaPago,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "proveedor_personafk",
                        column: x => x.idPersona,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "servicio_proveedorfk",
                        column: x => x.idervicio,
                        principalTable: "servicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    IdPersona = table.Column<int>(nullable: false),
                    nombre_usuario = table.Column<string>(type: "varchar(100)", nullable: false),
                    contrasena = table.Column<string>(nullable: false),
                    contrasena_hash = table.Column<byte[]>(nullable: true),
                    rol_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "usuario_persona_fk",
                        column: x => x.IdPersona,
                        principalTable: "persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuario_rol_fk",
                        column: x => x.rol_id,
                        principalTable: "rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "presupuesto_detalle",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fecha_creacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    fecha_modificacion_utc = table.Column<DateTime>(type: "datetime", nullable: false),
                    activo = table.Column<ulong>(type: "bit", nullable: false),
                    servicio = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    idServicio = table.Column<int>(type: "int", nullable: false),
                    idProducto = table.Column<int>(type: "int", nullable: false),
                    idPresupuesto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "presupuesto_detalle_presupuestofk",
                        column: x => x.idPresupuesto,
                        principalTable: "presupuesto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "presupuesto_detalle_productofk",
                        column: x => x.idProducto,
                        principalTable: "producto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "servicio_presupuestodetallefk",
                        column: x => x.idServicio,
                        principalTable: "servicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "id", "activo", "codigo", "descripcion", "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { 1, 1ul, "ADM", "Administrador", new DateTime(2024, 7, 2, 5, 42, 23, 253, DateTimeKind.Utc).AddTicks(1178), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "id", "activo", "codigo", "descripcion", "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { 2, 1ul, "USEST", "Usuario Estándar", new DateTime(2024, 7, 2, 5, 42, 23, 253, DateTimeKind.Utc).AddTicks(1178), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_id_provincia",
                table: "ciudad",
                column: "id_provincia");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_idCiudad",
                table: "cliente",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_CiudadId1",
                table: "cliente",
                column: "CiudadId1");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_idCuenta",
                table: "cliente",
                column: "idCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_CuentaId1",
                table: "cliente",
                column: "CuentaId1");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_idEmpresa",
                table: "cliente",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_EmpresaId1",
                table: "cliente",
                column: "EmpresaId1");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_idFormapago",
                table: "cliente",
                column: "idFormapago");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_FormaPagoId1",
                table: "cliente",
                column: "FormaPagoId1");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_idPersona",
                table: "cliente",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_PersonaId1",
                table: "cliente",
                column: "PersonaId1");

            migrationBuilder.CreateIndex(
                name: "IX_cuenta_idBanco",
                table: "cuenta",
                column: "idBanco");

            migrationBuilder.CreateIndex(
                name: "IX_cuenta_idTipocuenta",
                table: "cuenta",
                column: "idTipocuenta");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_idCiudad",
                table: "empleado",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_idPersona",
                table: "empleado",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_idTipoEmpresa",
                table: "empresa",
                column: "idTipoEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_evento_IdCiudad",
                table: "evento",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_ProductoId",
                table: "Inventario",
                column: "ProductoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_persona_idCiudad",
                table: "persona",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_persona_CiudadId1",
                table: "persona",
                column: "CiudadId1");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_EventoId",
                table: "presupuesto",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_idevento",
                table: "presupuesto",
                column: "idevento");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_detalle_idPresupuesto",
                table: "presupuesto_detalle",
                column: "idPresupuesto");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_detalle_idProducto",
                table: "presupuesto_detalle",
                column: "idProducto");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_detalle_idServicio",
                table: "presupuesto_detalle",
                column: "idServicio");

            migrationBuilder.CreateIndex(
                name: "IX_producto_CategoriaId",
                table: "producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_producto_idCategoria",
                table: "producto",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_idCiudad",
                table: "proveedor",
                column: "idCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_idCuenta",
                table: "proveedor",
                column: "idCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_idempresa",
                table: "proveedor",
                column: "idempresa");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdFormaPago",
                table: "proveedor",
                column: "IdFormaPago");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_idPersona",
                table: "proveedor",
                column: "idPersona");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_idervicio",
                table: "proveedor",
                column: "idervicio");

            migrationBuilder.CreateIndex(
                name: "IX_servicio_IdTipoServicio",
                table: "servicio",
                column: "IdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_IdPersona",
                table: "usuario",
                column: "IdPersona",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_rol_id",
                table: "usuario",
                column: "rol_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "presupuesto_detalle");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "presupuesto");

            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "cuenta");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "servicio");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "evento");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "banco");

            migrationBuilder.DropTable(
                name: "tipocuenta");

            migrationBuilder.DropTable(
                name: "tipoempresa");

            migrationBuilder.DropTable(
                name: "tipo_servicio");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "provincias");
        }
    }
}
