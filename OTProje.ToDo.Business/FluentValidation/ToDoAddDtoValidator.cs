using FluentValidation;

namespace OTProje.ToDo.Business.FluentValidation
{
    public class ToDoAddDtoValidator: AbstractValidator<Entities.Concrete.ToDo>
    {
        public ToDoAddDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("To Do Name is required.");
        }
    }
}