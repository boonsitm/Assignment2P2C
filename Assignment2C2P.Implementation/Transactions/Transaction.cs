﻿using Assignment2C2P.Domain.Transactions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment2C2P.Domain.Implementation.Transactions
{
    public class Transaction : ITransaction
    {
        [Key]
        [Required, MaxLength(50), StringLength(50)]
        public string TransactionId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
