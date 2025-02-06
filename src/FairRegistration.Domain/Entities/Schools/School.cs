using FairRegistration.Entities.SchoolStaffs;
using FairRegistration.Entities.StudentRegistrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Validation;

namespace FairRegistration.Entities.Schools
{
    /// <summary>
    /// School Entity
    /// </summary>
    public class School : FullAuditedAggregateRoot<Guid>
    {
        [MaxLength(128)]
        [NotNull]
        public virtual string Name { get; private set; }

        [MaxLength(512)]
        [NotNull]
        public virtual string Address { get; private set; }

        [MaxLength(256)]
        [NotNull]
        [EmailAddress]
        public virtual string Email { get; private set; }

        [MaxLength(16)]
        [NotNull]
        [Phone]
        public virtual string Phone { get; private set; }

        public virtual ICollection<SchoolStaff> StaffMembers { get; private set; }

        public virtual ICollection<StudentRegistration> StudentRegistrations { get; private set; }

        protected School()
        {

        }

        public School(Guid id, string name, string address, string email, string phone)
            : base(id)
        {
            SetName(name)
           .SetAddress(address)
           .SetEmail(email)
           .SetPhone(phone);

            StaffMembers = new List<SchoolStaff>();
            StudentRegistrations = new List<StudentRegistration>();
        }

        public School SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
            return this;
        }

        public School SetAddress([NotNull] string address)
        {
            Address = Check.NotNullOrWhiteSpace(address, nameof(address));
            return this;
        }

        public School SetEmail([NotNull] string email)
        {
            Email = Check.NotNullOrWhiteSpace(email, nameof(email));

            if (!email.Contains('@'))
            {
                throw new ArgumentException("Invalid email address.", nameof(email));
            }

            return this;
        }

        public School SetPhone([NotNull] string phone)
        {
            Phone = Check.NotNullOrWhiteSpace(phone, nameof(phone));
            return this;
        }

        public void AddStaffMember(SchoolStaff staff)
        {
            if (staff == null)
            {
                throw new ArgumentNullException(nameof(staff));
            }
            StaffMembers.Add(staff);
        }

        public void RegisterStudent(StudentRegistration registration)
        {
            if (registration == null)
            {
                throw new ArgumentNullException(nameof(registration));
            }
            StudentRegistrations.Add(registration);
        }
    }
}
