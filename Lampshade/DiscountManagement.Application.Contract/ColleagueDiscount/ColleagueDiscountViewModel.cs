﻿namespace DiscountManagement.Application.Contract.ColleagueDiscount
{
    public class ColleagueDiscountViewModel
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public int DiscountRate { get; set; }
        public string CreationDate { get; set; }
    }
}