using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Entities
{
    class Campaign
    {
        public int CampainId { get; set; }
        public string CampainName { get; set; }
        public decimal DiscountRate { get; set; } //indirim oranı
    }
}
