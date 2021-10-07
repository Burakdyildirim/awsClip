﻿using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(c => c.CommentContent).NotEmpty();
            RuleFor(c => c.CommentContent).MinimumLength(1);
            RuleFor(c => c.CommentContent).MaximumLength(300);
        }
    }
}
