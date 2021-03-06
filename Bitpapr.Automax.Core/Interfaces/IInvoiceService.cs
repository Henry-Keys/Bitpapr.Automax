﻿using System.Collections.Generic;
using Bitpapr.Automax.Core.Model;
using System;

namespace Bitpapr.Automax.Core.Services
{
    public interface IInvoiceService
    {
        Invoice GetByNumber(int number);
        IEnumerable<Invoice> GetLastIssuedInvoices(int maximumToRetrieve);
        Invoice GetLastIssuedInvoice();
        void AddNew(Customer customer, Vehicle vehicle,
            List<ServiceToProvide> servicesToProvide);
    }
}