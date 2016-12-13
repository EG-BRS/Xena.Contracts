using System;
using System.Collections;
using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class CreateOrderData
    {
        public CreateOrderData()
        {
            CreateTask = true;
        }

        public string ContextType { get; set; }
        public long? PartnerId { get; set; }
        public long? ProjectId { get; set; }
        public bool CreateTask { get; set; }
    }
}