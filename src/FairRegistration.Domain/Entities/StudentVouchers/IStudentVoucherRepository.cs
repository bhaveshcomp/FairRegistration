﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FairRegistration.Entities.StudentVouchers
{
    public interface IStudentVoucherRepository : IBasicRepository<StudentVoucher, Guid>
    {

    }
}
