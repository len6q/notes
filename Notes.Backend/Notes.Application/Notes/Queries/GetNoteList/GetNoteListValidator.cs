using FluentValidation;
using System;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class GetNoteListValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListValidator()
        {
            RuleFor(note => note.UserId).NotEqual(Guid.Empty);
        }
    }
}
