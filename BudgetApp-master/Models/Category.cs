﻿namespace BudgetApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ExpenseId { get; set; }
        public List<Expense> Expenses { get; set; } = new();
    }
}
