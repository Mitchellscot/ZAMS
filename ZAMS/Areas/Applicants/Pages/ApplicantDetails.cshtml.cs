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
    public class ApplicantDetailsModel : PageModel
    {
        private readonly IApplicantData applicantData;
        public Applicant Applicant { get; set; }
        [TempData]
        public string ConversationMessage { get; set; }
        public IEnumerable<Conversation> Conversations { get; set; }
        public ApplicantDetailsModel(IApplicantData applicantData)
        {
            this.applicantData = applicantData;
        }
        public IActionResult OnGet(int applicantId)
        {
            Applicant = applicantData.GetById(applicantId);
            Conversations = applicantData.GetConversations(applicantId);
            if (Applicant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}