using FairRegistration.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp;
using System.Diagnostics.CodeAnalysis;
using FairRegistration.Entities.StudentRegistrations;

namespace FairRegistration.Entities.StudentVouchers
{
    /// <summary>
    /// Student Voucher Entity
    /// </summary>
    public class StudentVoucher : AuditedAggregateRoot<Guid>
    {
        [MaxLength(128)]
        [NotNull]
        public virtual string VoucherCode { get; private set; }

        [NotNull]
        public virtual Guid StudentRegistrationId { get; private set; }

        [NotNull]
        public virtual VoucherType VoucherType { get; private set; }

        public virtual decimal Amount { get; private set; }

        [ForeignKey("StudentRegistrationId")]
        public virtual StudentRegistration StudentRegistration { get; private set; }

        protected StudentVoucher()
        {

        }

        public StudentVoucher(Guid id, Guid studentRegistrationId, string voucherCode, VoucherType voucherType, decimal amount)
            : base(id)
        {
            SetVoucherCode(voucherCode)
            .SetVoucherType(voucherType)
            .SetAmount(amount);

            StudentRegistrationId = studentRegistrationId;
        }

        public StudentVoucher SetVoucherCode([NotNull] string voucherCode)
        {
            VoucherCode = Check.NotNullOrWhiteSpace(voucherCode, nameof(voucherCode));
            return this;
        }

        public StudentVoucher SetVoucherType(VoucherType voucherType)
        {
            VoucherType = voucherType;
            return this;
        }

        public StudentVoucher SetAmount(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.", nameof(amount));
            }
            Amount = amount;
            return this;
        }
    }
}
