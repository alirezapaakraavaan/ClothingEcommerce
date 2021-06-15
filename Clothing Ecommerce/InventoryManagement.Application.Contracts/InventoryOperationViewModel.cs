﻿namespace InventoryManagement.Application.Contracts
{
    public class InventoryOperationViewModel
    {
        public long Id { get; set; }
        public bool Operation { get; set; }
        public long Count { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public long OperatorId { get; set; }
        public string Operator { get; set; }
        public string OperationDate { get; set; }
        public long CurrentCount { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }
    }
}