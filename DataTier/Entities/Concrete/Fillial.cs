using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataTier.Entities.Concrete
{
    public class Fillial
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите название филлиала")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Укажите расположение филлиала")]
        public string Location { get; set; }
        public DealerCenter Dealercenter { get; set; }
        public string CarBrands { get; set; }
        public FillialStatus FillialStatus { get; set; }
    }
}
