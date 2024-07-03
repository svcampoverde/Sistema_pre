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
                    nombre = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    idProvincia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.id);
                    table.ForeignKey(
                        name: "FK_ciudad_provincia",
                        column: x => x.idProvincia,
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
                table: "provincias",
                columns: new[] { "id", "nombre" },
                values: new object[,]
                {
                    { 1, "Azuay" },
                    { 25, "Zonas No Delimitadas" },
                    { 24, "Santa Elena" },
                    { 23, "Santo Domingo de Los Tsáchilas" },
                    { 22, "Orellana" },
                    { 21, "Sucumbíos" },
                    { 20, "Galápagos" },
                    { 19, "Zamora Chinchipe" },
                    { 18, "Tungurahua" },
                    { 17, "Pichincha" },
                    { 16, "Pastaza" },
                    { 15, "Napo" },
                    { 14, "Morona Santiago" },
                    { 12, "Los Rios" },
                    { 11, "Loja" },
                    { 10, "Imbabura" },
                    { 9, "Guayas" },
                    { 8, "Esmeraldas" },
                    { 7, "El Oro" },
                    { 6, "Chimborazo" },
                    { 5, "Cotopaxi" },
                    { 4, "Carchi" },
                    { 3, "Cañar" },
                    { 2, "Bolívar" },
                    { 13, "Manabi" }
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "id", "activo", "codigo", "descripcion", "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[,]
                {
                    { 1, 1ul, "ADM", "Administrador", new DateTime(2024, 7, 3, 6, 10, 33, 454, DateTimeKind.Utc).AddTicks(8756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1ul, "USEST", "Usuario Estándar", new DateTime(2024, 7, 3, 6, 10, 33, 454, DateTimeKind.Utc).AddTicks(8756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ciudad",
                columns: new[] { "id", "idProvincia", "nombre" },
                values: new object[,]
                {
                    { 1, 1, "Cuenca" },
                    { 142, 13, "Manta" },
                    { 143, 13, "Montecristi" },
                    { 144, 13, "Paján" },
                    { 145, 13, "Pichincha" },
                    { 146, 13, "Rocafuerte" },
                    { 147, 13, "Santa Ana" },
                    { 148, 13, "Sucre" },
                    { 149, 13, "Tosagua" },
                    { 150, 13, "24 de Mayo" },
                    { 151, 13, "Pedernales" },
                    { 152, 13, "Olmedo" },
                    { 141, 13, "Junín" },
                    { 153, 13, "Puerto López" },
                    { 155, 13, "Jaramijó" },
                    { 156, 13, "San Vicente" },
                    { 157, 14, "Morona" },
                    { 158, 14, "Gualaquiza" },
                    { 159, 14, "Limón Indanza" },
                    { 160, 14, "Palora" },
                    { 161, 14, "Santiago" },
                    { 162, 14, "Sucúa" },
                    { 163, 14, "Huamboya" },
                    { 164, 14, "San Juan Bosco" },
                    { 165, 14, "Taisha" },
                    { 154, 13, "Jama" },
                    { 166, 14, "Logroño" },
                    { 140, 13, "Jipijapa" },
                    { 138, 13, "El Carmen" },
                    { 114, 11, "Paltas" },
                    { 115, 11, "Puyango" },
                    { 116, 11, "Saraguro" },
                    { 117, 11, "Sozoranga" },
                    { 118, 11, "Zapotillo" },
                    { 119, 11, "Pindal" },
                    { 120, 11, "Quilanga" },
                    { 121, 11, "Olmedo" },
                    { 122, 12, "Babahoyo" },
                    { 123, 12, "Baba" },
                    { 124, 12, "Montalvo" },
                    { 139, 13, "Flavio Alfaro" },
                    { 125, 12, "Puebloviejo" },
                    { 127, 12, "Urdaneta" },
                    { 128, 12, "Ventanas" },
                    { 129, 12, "Vínces" },
                    { 130, 12, "Palenque" },
                    { 131, 12, "Buena Fé" },
                    { 132, 12, "Valencia" },
                    { 133, 12, "Mocache" },
                    { 134, 12, "Quinsaloma" },
                    { 135, 13, "Portoviejo" },
                    { 136, 13, "Bolívar" },
                    { 137, 13, "Chone" },
                    { 126, 12, "Quevedo" },
                    { 113, 11, "Macará" },
                    { 167, 14, "Pablo Sexto" },
                    { 169, 15, "Tena" },
                    { 199, 19, "Yantzaza (Yanzatza)" },
                    { 200, 19, "El Pangui" },
                    { 201, 19, "Centinela del Cóndor" },
                    { 202, 19, "Palanda" },
                    { 203, 19, "Paquisha" },
                    { 204, 20, "San Cristóbal" },
                    { 205, 20, "Isabela" },
                    { 206, 20, "Santa Cruz" },
                    { 207, 21, "Lago Agrio" },
                    { 208, 21, "Gonzalo Pizarro" },
                    { 209, 21, "Putumayo" },
                    { 198, 19, "Yacuambi" },
                    { 210, 21, "Shushufindi" },
                    { 212, 21, "Cascales" },
                    { 213, 21, "Cuyabeno" },
                    { 214, 22, "Orellana" },
                    { 215, 22, "Aguarico" },
                    { 216, 22, "La Joya de Los Sachas" },
                    { 217, 22, "Loreto" },
                    { 218, 23, "Santo Domingo" },
                    { 219, 24, "Santa Elena" },
                    { 220, 24, "La Libertad" },
                    { 221, 24, "Salinas" },
                    { 222, 25, "Las Golondrinas" },
                    { 211, 21, "Sucumbíos" },
                    { 168, 14, "Tiwintza" },
                    { 197, 19, "Nangaritza" },
                    { 195, 19, "Zamora" },
                    { 170, 15, "Archidona" },
                    { 171, 15, "El Chaco" },
                    { 172, 15, "Quijos" },
                    { 173, 15, "Carlos Julio Arosemena Tola" },
                    { 174, 16, "Pastaza" },
                    { 175, 16, "Mera" },
                    { 176, 16, "Santa Clara" },
                    { 177, 16, "Arajuno" },
                    { 179, 17, "Cayambe" },
                    { 180, 17, "Mejia" },
                    { 181, 17, "Pedro Moncayo" },
                    { 196, 19, "Chinchipe" },
                    { 182, 17, "Rumiñahui" },
                    { 184, 17, "Pedro Vicente Maldonado" },
                    { 185, 17, "Puerto Quito" },
                    { 186, 18, "Ambato" },
                    { 187, 18, "Baños de Agua Santa" },
                    { 188, 18, "Cevallos" },
                    { 189, 18, "Mocha" },
                    { 190, 18, "Patate" },
                    { 191, 18, "Quero" },
                    { 192, 18, "San Pedro de Pelileo" },
                    { 193, 18, "Santiago de Píllaro" },
                    { 194, 18, "Tisaleo" },
                    { 183, 17, "San Miguel de Los Bancos" },
                    { 223, 25, "Manga del Cura" },
                    { 112, 11, "Gonzanamá" },
                    { 110, 11, "Chaguarpamba" },
                    { 30, 4, "Tulcán" },
                    { 31, 4, "Bolívar" },
                    { 32, 4, "Espejo" },
                    { 33, 4, "Mira" },
                    { 34, 4, "Montúfar" },
                    { 35, 4, "San Pedro de Huaca" },
                    { 36, 5, "Latacunga" },
                    { 37, 5, "La Maná" },
                    { 38, 5, "Pangua" },
                    { 39, 5, "Pujilí" },
                    { 40, 5, "Salcedo" },
                    { 29, 3, "Suscal" },
                    { 41, 5, "Saquisilí" },
                    { 43, 6, "Riobamba" },
                    { 44, 6, "Alausí" },
                    { 45, 6, "Colta" },
                    { 46, 6, "Chambo" },
                    { 47, 6, "Chunchi" },
                    { 48, 6, "Guamote" },
                    { 49, 6, "Guano" },
                    { 50, 6, "Pallatanga" },
                    { 51, 6, "Penipe" },
                    { 52, 6, "Cumandá" },
                    { 53, 7, "Machala" },
                    { 42, 5, "Sigchos" },
                    { 54, 7, "Arenillas" },
                    { 28, 3, "Déleg" },
                    { 26, 3, "La Troncal" },
                    { 2, 1, "Girón" },
                    { 3, 1, "Gualaceo" },
                    { 4, 1, "Nabón" },
                    { 5, 1, "Paute" },
                    { 6, 1, "Pucará" },
                    { 7, 1, "San Fernando" },
                    { 8, 1, "Santa Isabel" },
                    { 9, 1, "Sigsig" },
                    { 10, 1, "Oña" },
                    { 11, 1, "Chordeleg" },
                    { 12, 1, "El Pan" },
                    { 27, 3, "El Tambo" },
                    { 13, 1, "Sevilla de Oro" },
                    { 15, 1, "Camilo Ponce Enríquez" },
                    { 16, 2, "Guaranda" },
                    { 17, 2, "Chillanes" },
                    { 18, 2, "Chimbo" },
                    { 19, 2, "Echeandía" },
                    { 20, 2, "San Miguel" },
                    { 21, 2, "Caluma" },
                    { 22, 2, "Las Naves" },
                    { 23, 3, "Azogues" },
                    { 24, 3, "Biblián" },
                    { 25, 3, "Cañar" },
                    { 14, 1, "Guachapala" },
                    { 111, 11, "Espíndola" },
                    { 55, 7, "Atahualpa" },
                    { 57, 7, "Chilla" },
                    { 86, 9, "Naranjito" },
                    { 87, 9, "Palestina" },
                    { 88, 9, "Pedro Carbo" },
                    { 89, 9, "Samborondón" },
                    { 90, 9, "Santa Lucía" },
                    { 91, 9, "Salitre (Urbina Jado)" },
                    { 92, 9, "San Jacinto de Yaguachi" },
                    { 93, 9, "Playas" },
                    { 94, 9, "Simón Bolívar" },
                    { 95, 9, "Coronel Marcelino Maridueña" },
                    { 96, 9, "Lomas de Sargentillo" },
                    { 85, 9, "Naranjal" },
                    { 97, 9, "Nobol" },
                    { 99, 9, "Isidro Ayora" },
                    { 100, 10, "Ibarra" },
                    { 101, 10, "Antonio Ante" },
                    { 102, 10, "Cotacachi" },
                    { 103, 10, "Otavalo" },
                    { 104, 10, "Pimampiro" },
                    { 105, 10, "San Miguel de Urcuquí" },
                    { 106, 11, "Loja" },
                    { 107, 11, "Calvas" },
                    { 108, 11, "Catamayo" },
                    { 109, 11, "Celica" },
                    { 98, 9, "General Antonio Elizalde" },
                    { 56, 7, "Balsas" },
                    { 84, 9, "Milagro" },
                    { 82, 9, "El Empalme" },
                    { 58, 7, "El Guabo" },
                    { 59, 7, "Huaquillas" },
                    { 60, 7, "Marcabelí" },
                    { 61, 7, "Pasaje" },
                    { 62, 7, "Piñas" },
                    { 63, 7, "Portovelo" },
                    { 64, 7, "Santa Rosa" },
                    { 65, 7, "Zaruma" },
                    { 66, 7, "Las Lajas" },
                    { 67, 8, "Esmeraldas" },
                    { 68, 8, "Eloy Alfaro" },
                    { 83, 9, "El Triunfo" },
                    { 69, 8, "Muisne" },
                    { 71, 8, "San Lorenzo" },
                    { 72, 8, "Atacames" },
                    { 73, 8, "Rioverde" },
                    { 74, 8, "La Concordia" },
                    { 75, 9, "Guayaquil" },
                    { 76, 9, "Alfredo Baquerizo Moreno (Juján)" },
                    { 77, 9, "Balao" },
                    { 78, 9, "Balzar" },
                    { 79, 9, "Colimes" },
                    { 80, 9, "Daule" },
                    { 81, 9, "Durán" },
                    { 70, 8, "Quinindé" },
                    { 224, 25, "El Piedrero" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ciudad_idProvincia",
                table: "ciudad",
                column: "idProvincia");

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
