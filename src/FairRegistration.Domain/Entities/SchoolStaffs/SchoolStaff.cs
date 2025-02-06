using FairRegistration.Entities.Schools;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Validation;

namespace FairRegistration.Entities.SchoolStaffs
{
    /// <summary>
    /// School Staff Entity
    /// </summary>
    public class SchoolStaff : FullAuditedAggregateRoot<Guid>
    {
        [MaxLength(64)]
        [NotNull]
        public virtual string FirstName { get; private set; }

        [MaxLength(64)]
        [NotNull]
        public virtual string LastName { get; private set; }

        [MaxLength(256)]
        [NotNull]
        [EmailAddress]
        public virtual string Email { get; private set; }

        [NotNull]
        public virtual Guid SchoolId { get; private set; }

        protected SchoolStaff()
        {

        }
        public SchoolStaff(Guid id, string firstName, string lastName, string email, Guid schoolId)
            : base(id)
        {
            SetFirstName(firstName)
            .SetLastName(lastName)
            .SetEmail(email);

            SchoolId = schoolId;
        }

        public SchoolStaff SetFirstName([NotNull] string firstName)
        {
            FirstName = Check.NotNullOrWhiteSpace(firstName, nameof(firstName));
            return this;
        }

        public SchoolStaff SetLastName([NotNull] string lastName)
        {
            LastName = Check.NotNullOrWhiteSpace(lastName, nameof(lastName));
            return this;
        }

        public SchoolStaff SetEmail([NotNull] string email)
        {
            Email = Check.NotNullOrWhiteSpace(email, nameof(email));

            if (!email.Contains('@'))
            {
                throw new ArgumentException("Invalid email address.", nameof(email));
            }

            return this;
        }
    }
}
