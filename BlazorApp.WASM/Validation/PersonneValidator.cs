using BlazorApp.WASM.Models;
using FluentValidation;

namespace BlazorApp.WASM.Validation;

public class PersonneValidator : AbstractValidator<Personne>
{
    public PersonneValidator()
    {
        RuleFor(p => p.Nom)
            .NotEmpty().WithMessage("Le nom est obligatoire.")
            .MinimumLength(2).WithMessage("Le nom doit contenir au moins 2 caractères.")
            .MaximumLength(256).WithMessage("Le nom ne peut pas dépasser 256 caractères.");
    }
}
