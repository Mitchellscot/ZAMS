﻿using System;
using System.Collections.Generic;
using System.Text;
using ZAMS.Domain.Applicants;

namespace ZAMS.Data.Applicants
{
    public interface IApplicantData
    {
        Applicant Add(Applicant newApplicant);
        IEnumerable<Applicant> GetAll();
        Applicant GetById(int id);
        IEnumerable<Applicant> GetByTraining();
        Applicant Update(Applicant updatedApplicant);
        Applicant Delete(int id);
        int Commit();
        Conversation AddConversation(Conversation newConversation);
        IEnumerable<Conversation> GetConversations(int id);
        Conversation GetConversationById(int id);
        Conversation UpdateConversation(Conversation updatedConversation);
        Conversation DeleteConversation(int id);

    }
}
