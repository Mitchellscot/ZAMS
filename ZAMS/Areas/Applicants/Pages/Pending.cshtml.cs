using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAMS.Data.Applicants;
using ZAMS.Domain.Applicants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZAMS.Pages.Applicants
{
    public class PendingModel : PageModel
    {
        private readonly IApplicantData applicantData;

        public IEnumerable<Applicant> Applicants { get; set; }
        public PendingModel(IApplicantData applicantData)
        {
            this.applicantData = applicantData;
        }
        public void OnGet()
        {
            Applicants = applicantData.GetByTraining();
        }
    }
}
