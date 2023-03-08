﻿using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal partial class OcpiExceptionalPeriodValidator : HttpValidator<OcpiExceptionalPeriod>
{
    public OcpiExceptionalPeriodValidator(string httpMethod) : base(httpMethod)
    {
        JsonRuleFor(x => x.PeriodBegin)
            .NotEmpty()
            .MustValidDateTime();

        JsonRuleFor(x => x.PeriodEnd)
            .NotEmpty()
            .MustValidDateTime();
    }
}