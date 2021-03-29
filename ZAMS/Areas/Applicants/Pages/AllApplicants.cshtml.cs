using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAMS.Data.Applicants;
using ZAMS.Domain.Applicants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZAMS
{
    public class AllApplicantsModel : PageModel
    {
        private readonly IApplicantData applicantData;
        public IEnumerable<Applicant> Applicants { get; set; }
        public IEnumerable<Applicant> ApplicantSearch { get; set; }
        [TempData]
        public string ApplicantMessage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public AllApplicantsModel(IApplicantData applicantData)
        {
            this.applicantData = applicantData;
        }
        public void OnGet()
        {
            Applicants = applicantData.GetAll();
            ApplicantSearch = GetApplicantByName(SearchTerm);
        }
        public IEnumerable<Applicant> GetApplicantByName(string name = null)
        {
            return from a in Applicants
                   where string.IsNullOrEmpty(name) || a.Name.StartsWith(name)
                   orderby a.Name
                   select a;
        }
    }
}