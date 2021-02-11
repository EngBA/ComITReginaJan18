using System;
using System.Collections.Generic;
using System.Text;

namespace FreightManagement.ValueObj
{
    public class Money
    {
        public readonly Currency Currency; 
        
        public readonly decimal Amount; 
        
        public Money(decimal amount, Currency currency) { 
            Amount = amount; 
            Currency = currency; 
        }
        public Money AddFunds(Money fundsToAdd)
        { 
            // because the money we're adding might 
            // be in a different currency, we'll service 
            // locate a money exchange Domain Service. 
            var newAmount = this.Amount + normalizedMoney.Amount; 
            return new Money(newAmount, this.Currency); } 
            } 
            public enum Currency { USD, GBP, EUR, JPY }
        }
