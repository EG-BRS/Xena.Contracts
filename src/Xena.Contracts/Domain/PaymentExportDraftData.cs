﻿using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PaymentExportDraftData : IHasIdDto
    {
        public long? Id { get; set; }
        public long[] PaymentIds { get; set; }
        public int DueDateDays { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        private string _dueDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DueDateDaysFriendly
        {
            get { return _dueDateDaysFriendly ?? DueDateDays.FriendlyString(); }
            set { _dueDateDaysFriendly = value; }
        }
        public long? PartnerSupplierContextId { get; set; }
        public string PaymentIdentification { get; set; }
        public string[] Errors { get; set; }
        public long ContextId { get; set; }
    }
}