using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models.Form
{
    public class FormModel
    {
        [Display(Name = "Nome")]
        public string Name { get; set; } = default!;

        [Display(Name = "Numero Qualquer")]
        public int UserNumber { get; set; } = default!;

        [Display(Name = "Data Datada")]
        public DateTime Date { get; set; } = default!;
    }
}
