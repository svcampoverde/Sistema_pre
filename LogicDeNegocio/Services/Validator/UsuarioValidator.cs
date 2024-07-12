using FluentValidation;

using LogicDeNegocio.Requests;

namespace LogicDeNegocio.Services.Validator
{
    internal class UsuarioValidator : AbstractValidator<UsuarioRequest>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.IdCiudad)
                .GreaterThan(0).WithMessage("Seleccione una ciudad válida.");

            RuleFor(u => u.IdRol)
                .GreaterThan(0).WithMessage("Seleccione un rol válido.");

            RuleFor(u => u.Cedula)
                .NotEmpty().WithMessage("La cédula es requerida.")
                .Matches(@"^\d+$").WithMessage("La cédula debe contener solo números.");

            RuleFor(u => u.Nombre)
                .NotEmpty().WithMessage("El nombre es requerido.");

            RuleFor(u => u.Apellido)
                .NotEmpty().WithMessage("El apellido es requerido.");

            RuleFor(u => u.Genero)
                .NotEmpty().WithMessage("El género es requerido.");

            RuleFor(u => u.Telefono)
                .Matches(@"^\d+$").When(u => !string.IsNullOrEmpty(u.Telefono))
                .WithMessage("El teléfono debe contener solo números.");

            RuleFor(u => u.Celular)
                .Matches(@"^\d+$").When(u => !string.IsNullOrEmpty(u.Celular))
                .WithMessage("El celular debe contener solo números.");

            RuleFor(u => u.Correo)
                .NotEmpty().WithMessage("El correo es requerido.")
                .EmailAddress().WithMessage("El correo debe ser válido.");

            RuleFor(u => u.Direccion)
                .NotEmpty().WithMessage("La dirección es requerida.");

            RuleFor(u => u.NombreUsuario)
                .NotEmpty().WithMessage("El nombre de usuario es requerido.");

            RuleFor(u => u.Clave)
                .NotEmpty().WithMessage("La clave es requerida.")
                .MinimumLength(6).WithMessage("La clave debe tener al menos 6 caracteres.");
        }
    }
}