using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace FairRegistration.Entities.StudentRegistrations
{
    /// <summary>
    /// Student Registration Entity
    /// </summary>
    public class StudentRegistration : FullAuditedAggregateRoot<Guid>
    {
        [MaxLength(64)]
        [NotNull]
        public virtual string FirstName { get; private set; }

        [MaxLength(64)]
        [NotNull]
        public virtual string LastName { get; private set; }

        [MaxLength(128)]
        [NotNull]
        public virtual string IdCardNumber { get; private set; }

        [MaxLength(256)]
        [NotNull]
        [EmailAddress]
        public virtual string Email { get; private set; }

        public virtual bool IsSelfRegistered { get; private set; }

        public virtual Guid? SchoolId { get; private set; }

        protected StudentRegistration()
        {

        }

        public StudentRegistration(Guid id, string firstName, string lastName, string idCardNumber, string email, bool isSelfRegistered, Guid schoolId)
            : base(id)
        {
            SetFirstName(firstName)
            .SetLastName(lastName)
            .SetIdCardNumber(idCardNumber)
            .SetEmail(email)
            .SetIsSelfRegistered(isSelfRegistered);

            SchoolId = schoolId;
        }

        public StudentRegistration SetFirstName([NotNull] string firstName)
        {
            FirstName = Check.NotNullOrWhiteSpace(firstName, nameof(firstName));
            return this;
        }

        public StudentRegistration SetLastName([NotNull] string lastName)
        {
            LastName = Check.NotNullOrWhiteSpace(lastName, nameof(lastName));
            return this;
        }

        public StudentRegistration SetIdCardNumber([NotNull] string idCardNumber)
        {
            IdCardNumber = Check.NotNullOrWhiteSpace(idCardNumber, nameof(idCardNumber));
            return this;
        }

        public StudentRegistration SetEmail([NotNull] string email)
        {
            Email = Check.NotNullOrWhiteSpace(email, nameof(email));

            if (!email.Contains('@'))
            {
                throw new ArgumentException("Invalid email address.", nameof(email));
            }

            return this;
        }

        public StudentRegistration SetIsSelfRegistered(bool isSelfRegistered)
        {
            IsSelfRegistered = isSelfRegistered;
            return this;
        }
    }
}
