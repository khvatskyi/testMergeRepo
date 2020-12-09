using FluentValidation;
using Sprint12_MVC.Models;

namespace Sprint12_MVC.Validators
{
    public class TriangleValidator : AbstractValidator<Triangle>
    {
        public TriangleValidator()
        {
            RuleFor(triangle => triangle.Side1)
                .LessThan(tr => tr.Side2 + tr.Side3).WithMessage("A triangle with this side does not exist")
                .GreaterThan(0);

            RuleFor(triangle => triangle.Side2)
                .LessThan(tr => tr.Side1 + tr.Side3).WithMessage("A triangle with this side does not exist")
                .GreaterThan(0);

            RuleFor(triangle => triangle.Side3)
                .LessThan(tr => tr.Side1 + tr.Side2).WithMessage("A triangle with this side does not exist")
                .GreaterThan(0);
        }
    }
}
