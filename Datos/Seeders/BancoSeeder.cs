using Datos.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Collections.Generic;
using System;
namespace Datos.Seeders
{
    public static class BancoSeeder
    {
        public static void SeedBancos(this EntityTypeBuilder<Banco> entity)
        {
            entity.HasData(
                new Banco { Id = 1, Nombre = "BANCO PICHINCHA MIAMI AGENCY", Descripcion = "BANCO PICHINCHA MIAMI AGENCY", Direccion = "", IdCategoriaBanco = 8, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 2, Nombre = "ALMACENERA ALMACOPIO S.A.", Descripcion = "ALMACENERA ALMACOPIO S.A.", Direccion = "KM. 3 1/2 VIA DURAN TAMBO (ENTRANDO AV. TANASA)", Telefono = "(04)2800-114 - 2800-115", IdCategoriaBanco = 9, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 3, Nombre = "ALMACENERA DEL AGRO S.A. (ALMAGRO)", Descripcion = "ALMACENERA DEL AGRO S.A. (ALMAGRO)", Direccion = "AV. 25 JULIO KM 4 1/2 VIA PTO MARITIMO", Telefono = "04-2484700 al 707", IdCategoriaBanco = 9, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 4, Nombre = "ALMACENERA DEL ECUADOR S.A. ALMESA", Descripcion = "ALMACENERA DEL ECUADOR S.A. ALMESA", Direccion = "CADENA Y AV. MONSEÑOR DOMINGO, COMIN, FRENTE A LA CDLA. PRADERA II Y IIIJUNTO A LAS BODEGAS DE CONAUTO", Telefono = "(04)2490-070/ (04)2495-933", IdCategoriaBanco = 9, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 5, Nombre = "BANCO FINANCIERO DEL PERU", Descripcion = "BANCO FINANCIERO DEL PERU", Direccion = "", IdCategoriaBanco = 5, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 6, Nombre = "CITIBANK, N.A. SUCURSAL ECUADOR", Descripcion = "CITIBANK, N.A. SUCURSAL ECUADOR", Direccion = "AV REPUBLICA DEL SALVADOR N36-230 Y AV NNUU", Telefono = "3939063", IdCategoriaBanco = 4, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 7, Nombre = "BANCO AMAZONAS S.A.", Descripcion = "BANCO AMAZONAS S.A.", Direccion = "AV. FRANCISCO DE ORELLANA 238 Y ALBERTO BORGES", Telefono = "(04)2683-600", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 8, Nombre = "BANCO AUSTRO S.A.", Descripcion = "BANCO AUSTRO S.A.", Direccion = "SUCRE Y BORRERO ESQ.", Telefono = "07831222", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 9, Nombre = "BANCO GUAYAQUIL S.A.", Descripcion = "BANCO GUAYAQUIL S.A.", Direccion = "CALLES PICHINCHA 105-107 Y FRANCISCO DE PAULA YCAZA", Telefono = "(04)3730-100", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 10, Nombre = "BANCO BOLIVARIANO C.A.", Descripcion = "BANCO BOLIVARIANO C.A.", Direccion = "JUNIN 200 Y PANAMA", Telefono = "2305000", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 11, Nombre = "BANCO COMERCIAL DE MANABI S.A.", Descripcion = "BANCO COMERCIAL DE MANABI S.A.", Direccion = "AV. REALES TAMARINDO Y ALAMOS", Telefono = "05 632 222 / 632 223", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 12, Nombre = "BANCO DEL LITORAL S.A.", Descripcion = "BANCO DEL LITORAL S.A.", Direccion = "MALECON 514 E IMBABURA", Telefono = "59342313151", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 13, Nombre = "BANCO GENERAL RUMIÑAHUI S.A.", Descripcion = "BANCO GENERAL RUMIÑAHUI S.A.", Direccion = "AV. REPUBLICA E37-55 Y MARTIN CARRION", Telefono = "2509-929 2221-372", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 14, Nombre = "BANCO INTERNACIONAL S.A.", Descripcion = "BANCO INTERNACIONAL S.A.", Direccion = "AV. PATRIA E4-21 Y 9 DE OCTUBRE", Telefono = "(02)565-547548/549/550", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 15, Nombre = "BANCO DE LOJA S.A.", Descripcion = "BANCO DE LOJA S.A.", Direccion = "ROCAFUERTE y BOLIVAR (ESQ.)", Telefono = "(07)2571 682", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 16, Nombre = "BANCO DE MACHALA S.A.", Descripcion = "BANCO DE MACHALA S.A.", Direccion = "9 DE MAYO Y ROCAFUERTE ESQUINA", Telefono = "59372930100", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 17, Nombre = "BANCO DEL PACIFICO S.A.", Descripcion = "BANCO DEL PACIFICO S.A.", Direccion = "P.YCAZA 200 ENTRE PEDRO CARBO Y PICHINCHA", Telefono = "(04)2328333 -2566010", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 18, Nombre = "BANCO PICHINCHA C.A.", Descripcion = "BANCO PICHINCHA C.A.", Direccion = "AV. AMAZONAS 4560 Y PEREIRA", Telefono = "980-980/981", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 19, Nombre = "BANCO DE LA PRODUCCION S.A.", Descripcion = "BANCO DE LA PRODUCCION S.A.", Direccion = "AV. SIMON BOLIVAR Y VIA A NAYON, COMPLEJO CORPORATIVO EKOPARK, TORRE I", Telefono = "2563-900", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 20, Nombre = "BANCO SOLIDARIO S.A.", Descripcion = "BANCO SOLIDARIO S.A.", Direccion = "AV. AMAZONAS N36-69 Y COREA", Telefono = "(02) 3950600", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 21, Nombre = "BANCO COOPNACIONAL S.A.", Descripcion = "BANCO COOPNACIONAL S.A.", Direccion = "CAPITAN NAJERA 4210 Y YAHUACHI", Telefono = "(04)2471118", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 22, Nombre = "BANCO DE LA PRODUCCION S.A. PRODUBANCO", Descripcion = "BANCO DE LA PRODUCCION S.A. PRODUBANCO", Direccion = "AV. 12 DE OCTUBRE Y CAAMANO, EDIFICIO WORLD TRADE CENTER", Telefono = "3988600", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 23, Nombre = "BANCO RIO S.A.", Descripcion = "BANCO RIO S.A.", Direccion = "VELEZ 303 Y CORDOVA ESQUINA", Telefono = "2513140", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 24, Nombre = "BANCO SOLIDARIO S.A.", Descripcion = "BANCO SOLIDARIO S.A.", Direccion = "AV. AMAZONAS N36-69 Y COREA", Telefono = "(02) 3950600", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 25, Nombre = "BANCO TERRITORIAL S.A.", Descripcion = "BANCO TERRITORIAL S.A.", Direccion = "9 DE OCTUBRE 300 Y MALECON", Telefono = "2323700", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 26, Nombre = "BANCO CAPITAL S.A.", Descripcion = "BANCO CAPITAL S.A.", Direccion = "AV. 6 DE DICIEMBRE N24-600 Y COLON", Telefono = "2433650", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 27, Nombre = "BANCO PROCREDIT S.A.", Descripcion = "BANCO PROCREDIT S.A.", Direccion = "AV. 10 DE AGOSTO N36-150 Y MURGEON", Telefono = "2446000", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 28, Nombre = "BANCO PROMERICA S.A.", Descripcion = "BANCO PROMERICA S.A.", Direccion = "AV. FRANCISCO DE ORELLANA 240 Y AV. JOSE CASTILLO", Telefono = "2696000", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 29, Nombre = "BANCO DE LA UNION S.A.", Descripcion = "BANCO DE LA UNION S.A.", Direccion = "AV. 9 DE OCTUBRE Y MALECON", Telefono = "2325151", IdCategoriaBanco = 1, Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new Banco { Id = 30, Nombre = "ALMACENERA GUAYAQUIL CEM ALMAQUIL", Descripcion = "ALMACENERA GUAYAQUIL CEM ALMAQUIL", Direccion = "AV. 25 DE JULIO KM 4 1/2 VIA PUERTO MARITIMO", Telefono = "(04)2488-672", IdCategoriaBanco = 9, Activo = true, FechaCreacionUTC = DateTime.UtcNow }
            );
        }
    }
}
