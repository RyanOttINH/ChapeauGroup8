﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        public Bill (int id, PaymentMethod paymentMethod, double tax6, double tax21, double tip, double total, double paid)
        {
            BillID = id;
            PaymentMethod = paymentMethod;
            Tax6 = tax6;
            Tax21 = tax21;
            Tip = tip;
            Total = total;
            AmountPaid = paid;
        }

        public Bill(int id) : this(id, 0, 0, 0, 0, 0, 0)
        {
            BillID = id;
        }

        public int BillID { get; set; }
        public PaymentMethod PaymentMethod { get; set; } //cash, pin, AMEX or VISA
        public double Tax6 { get; set; } //amount of tax for items with 6% VAT
        public double Tax21 { get; set; } //amount of tax for items with 21% VAT
        public double Tip { get; set; } //value of optional tip left by customer
        public double Total { get; set; } //total sum to be paid by customer
        public double AmountPaid { get; set; } //actual amount paid by customer

        public override string ToString()
        {
            return $"Bill - ID: {BillID} - Payment Method: {PaymentMethod} - 6%Tax: {Tax6} - 21%Tax: {Tax21} - Tip: {Tip} - Total: {Total} - Amount Paid by Customer: {AmountPaid}";
        }
    }

    public enum PaymentMethod
    {
        cash = 0, pin, AMEX, VISA
    }
}
